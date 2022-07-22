using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WordPad
{
    public partial class Form1 : Form
    {
        FontStyle sty = FontStyle.Regular;

        public Form1()
        {
            InitializeComponent();
            List<string> fonts = new List<string>();
            List<string> colors = new List<string>();
            List<string> size = new List<string>();
            foreach (var font in FontFamily.Families)
            {
                fonts.Add(font.Name);
            }

            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                {
                    colors.Add(prop.Name);
                }
            }
            for (int i = 6; i < 100; i++)
            {
                if (i % 2 == 0)
                    size.Add(i.ToString());
            }
            CB_Size.Items.AddRange(size.ToArray());
            CB_Size.SelectedIndex = 4;
            CB_Font.Items.AddRange(fonts.ToArray());
            CB_Font.SelectedIndex = 2;
            CB_Color.Items.AddRange(colors.ToArray());
            CB_Color.SelectedIndex = 8;
            Btn_AligL.BackColor = Color.Aqua;
            Btn_StyleR.BackColor = Color.Aqua;
        }
        private void StyleBtn_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                Btn_StyleB.BackColor = Color.White;
                Btn_StyleR.BackColor = Color.White;
                Btn_StyleI.BackColor = Color.White;
                btn.BackColor = Color.Aqua;
                switch (btn.Text)
                {
                    case "R": sty = FontStyle.Regular; break;
                    case "B": sty = FontStyle.Bold; break;
                    case "I": sty = FontStyle.Italic; break;
                }
                RTxtb_Body.SelectionFont = new Font(CB_Font.Text, Convert.ToInt32(CB_Size.Text), sty);
            }
        }

        private void AlignmentBtn_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                Btn_AligC.BackColor = Color.White;
                Btn_AligR.BackColor = Color.White;
                Btn_AligL.BackColor = Color.White;
                button.BackColor = Color.Aqua;
                switch (button.Text)
                {
                    case "L": RTxtb_Body.SelectionAlignment = HorizontalAlignment.Left; break;
                    case "C": RTxtb_Body.SelectionAlignment = HorizontalAlignment.Center; break;
                    case "R": RTxtb_Body.SelectionAlignment = HorizontalAlignment.Right; break;
                }
            }
        }

        private void CB_Font_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Font.SelectedItem != null && CB_Size.SelectedItem != null)
                RTxtb_Body.SelectionFont = new Font(CB_Font.SelectedItem.ToString(), Convert.ToInt32(CB_Size.SelectedItem.ToString()));
        }

        private void CB_Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Font.SelectedItem != null && CB_Size.SelectedItem != null) 
                RTxtb_Body.SelectionFont = new Font(CB_Font.SelectedItem.ToString(), Convert.ToInt32(CB_Size.SelectedItem.ToString()), sty);
        }

        private void CB_Color_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Color.SelectedItem != null)
                RTxtb_Body.SelectionColor = Color.FromName(CB_Color.SelectedItem.ToString());
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string str = fileDialog.FileName;
                if (!str.Contains(".txt"))
                    str += ".txt";
                using (StreamWriter writer = new StreamWriter(str))
                {
                    writer.Write(RTxtb_Body.Text);
                }
            }
        }

        private void Btn_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter= "text file|*.txt|  Word Text File|*.docx| Rich Text File|*.rft";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                using(StreamReader reader = new StreamReader(fileDialog.FileName))
                {
                    RTxtb_Body.Text = reader.ReadToEnd();
                }
            }
        }
    }
}
