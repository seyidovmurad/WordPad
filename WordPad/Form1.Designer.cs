
namespace WordPad
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pnl_Header = new System.Windows.Forms.Panel();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Load = new System.Windows.Forms.Button();
            this.Btn_AligR = new System.Windows.Forms.Button();
            this.Btn_StyleR = new System.Windows.Forms.Button();
            this.Btn_AligC = new System.Windows.Forms.Button();
            this.Btn_AligL = new System.Windows.Forms.Button();
            this.Btn_StyleI = new System.Windows.Forms.Button();
            this.Lbl_Alignment = new System.Windows.Forms.Label();
            this.Btn_StyleB = new System.Windows.Forms.Button();
            this.Lbl_FontStyle = new System.Windows.Forms.Label();
            this.Lbl_Color = new System.Windows.Forms.Label();
            this.CB_Color = new System.Windows.Forms.ComboBox();
            this.Lbl_Size = new System.Windows.Forms.Label();
            this.CB_Size = new System.Windows.Forms.ComboBox();
            this.CB_Font = new System.Windows.Forms.ComboBox();
            this.Lbl_Font = new System.Windows.Forms.Label();
            this.RTxtb_Body = new System.Windows.Forms.RichTextBox();
            this.Pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Header
            // 
            this.Pnl_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_Header.Controls.Add(this.Btn_Save);
            this.Pnl_Header.Controls.Add(this.Btn_Load);
            this.Pnl_Header.Controls.Add(this.Btn_AligR);
            this.Pnl_Header.Controls.Add(this.Btn_StyleR);
            this.Pnl_Header.Controls.Add(this.Btn_AligC);
            this.Pnl_Header.Controls.Add(this.Btn_AligL);
            this.Pnl_Header.Controls.Add(this.Btn_StyleI);
            this.Pnl_Header.Controls.Add(this.Lbl_Alignment);
            this.Pnl_Header.Controls.Add(this.Btn_StyleB);
            this.Pnl_Header.Controls.Add(this.Lbl_FontStyle);
            this.Pnl_Header.Controls.Add(this.Lbl_Color);
            this.Pnl_Header.Controls.Add(this.CB_Color);
            this.Pnl_Header.Controls.Add(this.Lbl_Size);
            this.Pnl_Header.Controls.Add(this.CB_Size);
            this.Pnl_Header.Controls.Add(this.CB_Font);
            this.Pnl_Header.Controls.Add(this.Lbl_Font);
            this.Pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Header.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Header.Name = "Pnl_Header";
            this.Pnl_Header.Size = new System.Drawing.Size(1080, 76);
            this.Pnl_Header.TabIndex = 0;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(673, 33);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(110, 26);
            this.Btn_Save.TabIndex = 7;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Load
            // 
            this.Btn_Load.Location = new System.Drawing.Point(801, 33);
            this.Btn_Load.Name = "Btn_Load";
            this.Btn_Load.Size = new System.Drawing.Size(110, 26);
            this.Btn_Load.TabIndex = 7;
            this.Btn_Load.Text = "Load";
            this.Btn_Load.UseVisualStyleBackColor = true;
            this.Btn_Load.Click += new System.EventHandler(this.Btn_Load_Click);
            // 
            // Btn_AligR
            // 
            this.Btn_AligR.BackColor = System.Drawing.Color.White;
            this.Btn_AligR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AligR.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AligR.Location = new System.Drawing.Point(481, 33);
            this.Btn_AligR.Name = "Btn_AligR";
            this.Btn_AligR.Size = new System.Drawing.Size(30, 26);
            this.Btn_AligR.TabIndex = 5;
            this.Btn_AligR.Text = "R";
            this.Btn_AligR.UseVisualStyleBackColor = false;
            this.Btn_AligR.Click += new System.EventHandler(this.AlignmentBtn_Click);
            // 
            // Btn_StyleR
            // 
            this.Btn_StyleR.BackColor = System.Drawing.Color.White;
            this.Btn_StyleR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_StyleR.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_StyleR.Location = new System.Drawing.Point(358, 33);
            this.Btn_StyleR.Name = "Btn_StyleR";
            this.Btn_StyleR.Size = new System.Drawing.Size(30, 26);
            this.Btn_StyleR.TabIndex = 5;
            this.Btn_StyleR.Text = "R";
            this.Btn_StyleR.UseVisualStyleBackColor = false;
            this.Btn_StyleR.Click += new System.EventHandler(this.StyleBtn_Click);
            // 
            // Btn_AligC
            // 
            this.Btn_AligC.BackColor = System.Drawing.Color.White;
            this.Btn_AligC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AligC.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AligC.Location = new System.Drawing.Point(445, 33);
            this.Btn_AligC.Name = "Btn_AligC";
            this.Btn_AligC.Size = new System.Drawing.Size(30, 26);
            this.Btn_AligC.TabIndex = 5;
            this.Btn_AligC.Text = "C";
            this.Btn_AligC.UseVisualStyleBackColor = false;
            this.Btn_AligC.Click += new System.EventHandler(this.AlignmentBtn_Click);
            // 
            // Btn_AligL
            // 
            this.Btn_AligL.BackColor = System.Drawing.Color.White;
            this.Btn_AligL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AligL.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AligL.Location = new System.Drawing.Point(409, 33);
            this.Btn_AligL.Name = "Btn_AligL";
            this.Btn_AligL.Size = new System.Drawing.Size(30, 26);
            this.Btn_AligL.TabIndex = 5;
            this.Btn_AligL.Text = "L";
            this.Btn_AligL.UseVisualStyleBackColor = false;
            this.Btn_AligL.Click += new System.EventHandler(this.AlignmentBtn_Click);
            // 
            // Btn_StyleI
            // 
            this.Btn_StyleI.BackColor = System.Drawing.Color.White;
            this.Btn_StyleI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_StyleI.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_StyleI.Location = new System.Drawing.Point(322, 33);
            this.Btn_StyleI.Name = "Btn_StyleI";
            this.Btn_StyleI.Size = new System.Drawing.Size(30, 26);
            this.Btn_StyleI.TabIndex = 5;
            this.Btn_StyleI.Text = "I";
            this.Btn_StyleI.UseVisualStyleBackColor = false;
            this.Btn_StyleI.Click += new System.EventHandler(this.StyleBtn_Click);
            // 
            // Lbl_Alignment
            // 
            this.Lbl_Alignment.AutoSize = true;
            this.Lbl_Alignment.Location = new System.Drawing.Point(415, 12);
            this.Lbl_Alignment.Name = "Lbl_Alignment";
            this.Lbl_Alignment.Size = new System.Drawing.Size(88, 18);
            this.Lbl_Alignment.TabIndex = 4;
            this.Lbl_Alignment.Text = "Alignment";
            // 
            // Btn_StyleB
            // 
            this.Btn_StyleB.BackColor = System.Drawing.Color.White;
            this.Btn_StyleB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_StyleB.Location = new System.Drawing.Point(286, 33);
            this.Btn_StyleB.Name = "Btn_StyleB";
            this.Btn_StyleB.Size = new System.Drawing.Size(30, 26);
            this.Btn_StyleB.TabIndex = 5;
            this.Btn_StyleB.Text = "B";
            this.Btn_StyleB.UseVisualStyleBackColor = false;
            this.Btn_StyleB.Click += new System.EventHandler(this.StyleBtn_Click);
            // 
            // Lbl_FontStyle
            // 
            this.Lbl_FontStyle.AutoSize = true;
            this.Lbl_FontStyle.Location = new System.Drawing.Point(292, 12);
            this.Lbl_FontStyle.Name = "Lbl_FontStyle";
            this.Lbl_FontStyle.Size = new System.Drawing.Size(90, 18);
            this.Lbl_FontStyle.TabIndex = 4;
            this.Lbl_FontStyle.Text = "Font Style";
            // 
            // Lbl_Color
            // 
            this.Lbl_Color.AutoSize = true;
            this.Lbl_Color.Location = new System.Drawing.Point(569, 12);
            this.Lbl_Color.Name = "Lbl_Color";
            this.Lbl_Color.Size = new System.Drawing.Size(51, 18);
            this.Lbl_Color.TabIndex = 3;
            this.Lbl_Color.Text = "Color";
            // 
            // CB_Color
            // 
            this.CB_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Color.FormattingEnabled = true;
            this.CB_Color.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CB_Color.Location = new System.Drawing.Point(532, 33);
            this.CB_Color.Name = "CB_Color";
            this.CB_Color.Size = new System.Drawing.Size(116, 26);
            this.CB_Color.TabIndex = 2;
            this.CB_Color.SelectedIndexChanged += new System.EventHandler(this.CB_Color_SelectedIndexChanged);
            // 
            // Lbl_Size
            // 
            this.Lbl_Size.AutoSize = true;
            this.Lbl_Size.Location = new System.Drawing.Point(197, 12);
            this.Lbl_Size.Name = "Lbl_Size";
            this.Lbl_Size.Size = new System.Drawing.Size(42, 18);
            this.Lbl_Size.TabIndex = 3;
            this.Lbl_Size.Text = "Size";
            // 
            // CB_Size
            // 
            this.CB_Size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Size.FormattingEnabled = true;
            this.CB_Size.Location = new System.Drawing.Point(187, 33);
            this.CB_Size.Name = "CB_Size";
            this.CB_Size.Size = new System.Drawing.Size(63, 26);
            this.CB_Size.TabIndex = 2;
            this.CB_Size.SelectedIndexChanged += new System.EventHandler(this.CB_Size_SelectedIndexChanged);
            // 
            // CB_Font
            // 
            this.CB_Font.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Font.DropDownWidth = 190;
            this.CB_Font.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Font.FormattingEnabled = true;
            this.CB_Font.Location = new System.Drawing.Point(21, 33);
            this.CB_Font.Name = "CB_Font";
            this.CB_Font.Size = new System.Drawing.Size(141, 26);
            this.CB_Font.TabIndex = 1;
            this.CB_Font.SelectedIndexChanged += new System.EventHandler(this.CB_Font_SelectedIndexChanged);
            // 
            // Lbl_Font
            // 
            this.Lbl_Font.AutoSize = true;
            this.Lbl_Font.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Font.Location = new System.Drawing.Point(48, 12);
            this.Lbl_Font.Name = "Lbl_Font";
            this.Lbl_Font.Size = new System.Drawing.Size(45, 18);
            this.Lbl_Font.TabIndex = 0;
            this.Lbl_Font.Text = "Font";
            // 
            // RTxtb_Body
            // 
            this.RTxtb_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTxtb_Body.Location = new System.Drawing.Point(0, 76);
            this.RTxtb_Body.Name = "RTxtb_Body";
            this.RTxtb_Body.Size = new System.Drawing.Size(1080, 544);
            this.RTxtb_Body.TabIndex = 1;
            this.RTxtb_Body.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 620);
            this.Controls.Add(this.RTxtb_Body);
            this.Controls.Add(this.Pnl_Header);
            this.MaximumSize = new System.Drawing.Size(1096, 659);
            this.MinimumSize = new System.Drawing.Size(1096, 659);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Pnl_Header.ResumeLayout(false);
            this.Pnl_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Header;
        private System.Windows.Forms.Label Lbl_Size;
        private System.Windows.Forms.ComboBox CB_Size;
        private System.Windows.Forms.ComboBox CB_Font;
        private System.Windows.Forms.Label Lbl_Font;
        private System.Windows.Forms.Button Btn_StyleR;
        private System.Windows.Forms.Button Btn_StyleI;
        private System.Windows.Forms.Button Btn_StyleB;
        private System.Windows.Forms.Label Lbl_FontStyle;
        private System.Windows.Forms.Button Btn_AligR;
        private System.Windows.Forms.Button Btn_AligC;
        private System.Windows.Forms.Button Btn_AligL;
        private System.Windows.Forms.Label Lbl_Alignment;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Load;
        private System.Windows.Forms.Label Lbl_Color;
        private System.Windows.Forms.RichTextBox RTxtb_Body;
        private System.Windows.Forms.ComboBox CB_Color;
    }
}

