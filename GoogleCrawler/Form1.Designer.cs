namespace GoogleCrawler
{
  partial class Form1
  {
    /// <summary>
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 디자이너에서 생성한 코드

    /// <summary>
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent()
    {
            this.label2 = new System.Windows.Forms.Label();
            this.Search_Tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Search_Lbx = new System.Windows.Forms.ListBox();
            this.Video_Lbx = new System.Windows.Forms.ListBox();
            this.Search_Btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Option1_Rbn = new System.Windows.Forms.RadioButton();
            this.Option2_Rbn = new System.Windows.Forms.RadioButton();
            this.Option3_Rbn = new System.Windows.Forms.RadioButton();
            this.Option4_Rbn = new System.Windows.Forms.RadioButton();
            this.Option5_Rbn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "검색어 입력";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Search_Tbx
            // 
            this.Search_Tbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Search_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Search_Tbx.Location = new System.Drawing.Point(12, 70);
            this.Search_Tbx.Margin = new System.Windows.Forms.Padding(4);
            this.Search_Tbx.Multiline = true;
            this.Search_Tbx.Name = "Search_Tbx";
            this.Search_Tbx.Size = new System.Drawing.Size(201, 34);
            this.Search_Tbx.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LavenderBlush;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(235, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1177, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "구글 통합 검색 결과";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Lavender;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(235, 461);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1176, 40);
            this.label5.TabIndex = 11;
            this.label5.Text = "구글 동영상 검색 결과";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Search_Lbx
            // 
            this.Search_Lbx.FormattingEnabled = true;
            this.Search_Lbx.ItemHeight = 20;
            this.Search_Lbx.Location = new System.Drawing.Point(234, 150);
            this.Search_Lbx.Name = "Search_Lbx";
            this.Search_Lbx.Size = new System.Drawing.Size(1177, 304);
            this.Search_Lbx.TabIndex = 12;
            this.Search_Lbx.SelectedIndexChanged += new System.EventHandler(this.Search_Lbx_SelectedIndexChanged);
            // 
            // Video_Lbx
            // 
            this.Video_Lbx.FormattingEnabled = true;
            this.Video_Lbx.ItemHeight = 20;
            this.Video_Lbx.Location = new System.Drawing.Point(234, 506);
            this.Video_Lbx.Name = "Video_Lbx";
            this.Video_Lbx.Size = new System.Drawing.Size(1177, 244);
            this.Video_Lbx.TabIndex = 13;
            this.Video_Lbx.SelectedIndexChanged += new System.EventHandler(this.Video_Lbx_SelectedIndexChanged);
            // 
            // Search_Btn
            // 
            this.Search_Btn.BackColor = System.Drawing.Color.PapayaWhip;
            this.Search_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Search_Btn.FlatAppearance.BorderColor = System.Drawing.Color.PapayaWhip;
            this.Search_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Search_Btn.Location = new System.Drawing.Point(1, 610);
            this.Search_Btn.Name = "Search_Btn";
            this.Search_Btn.Size = new System.Drawing.Size(231, 65);
            this.Search_Btn.TabIndex = 14;
            this.Search_Btn.Text = "검색 실행 (Enter)";
            this.Search_Btn.UseVisualStyleBackColor = false;
            this.Search_Btn.Click += new System.EventHandler(this.Search_Btn_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(235, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1176, 50);
            this.label7.TabIndex = 17;
            this.label7.Text = "구글";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(234, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 717);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1420, 1);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1411, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Google Search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Option1_Rbn
            // 
            this.Option1_Rbn.AutoSize = true;
            this.Option1_Rbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Option1_Rbn.Location = new System.Drawing.Point(10, 150);
            this.Option1_Rbn.Name = "Option1_Rbn";
            this.Option1_Rbn.Size = new System.Drawing.Size(192, 22);
            this.Option1_Rbn.TabIndex = 27;
            this.Option1_Rbn.Text = "\"\" 검색 (검색어 반드시 포함)";
            this.Option1_Rbn.UseVisualStyleBackColor = true;
            // 
            // Option2_Rbn
            // 
            this.Option2_Rbn.AutoSize = true;
            this.Option2_Rbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Option2_Rbn.Location = new System.Drawing.Point(10, 60);
            this.Option2_Rbn.Name = "Option2_Rbn";
            this.Option2_Rbn.Size = new System.Drawing.Size(189, 22);
            this.Option2_Rbn.TabIndex = 28;
            this.Option2_Rbn.Text = "Intitle: (제목에 반드시 포함)";
            this.Option2_Rbn.UseVisualStyleBackColor = true;
            // 
            // Option3_Rbn
            // 
            this.Option3_Rbn.AutoSize = true;
            this.Option3_Rbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Option3_Rbn.Location = new System.Drawing.Point(10, 90);
            this.Option3_Rbn.Name = "Option3_Rbn";
            this.Option3_Rbn.Size = new System.Drawing.Size(190, 22);
            this.Option3_Rbn.TabIndex = 29;
            this.Option3_Rbn.Text = "Intext: (본문에 반드시 포함)";
            this.Option3_Rbn.UseVisualStyleBackColor = true;
            // 
            // Option4_Rbn
            // 
            this.Option4_Rbn.AutoSize = true;
            this.Option4_Rbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Option4_Rbn.Location = new System.Drawing.Point(10, 120);
            this.Option4_Rbn.Name = "Option4_Rbn";
            this.Option4_Rbn.Size = new System.Drawing.Size(170, 20);
            this.Option4_Rbn.TabIndex = 30;
            this.Option4_Rbn.Text = "Filetype: (EX : PDF java)";
            this.Option4_Rbn.UseVisualStyleBackColor = true;
            // 
            // Option5_Rbn
            // 
            this.Option5_Rbn.AutoSize = true;
            this.Option5_Rbn.Checked = true;
            this.Option5_Rbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Option5_Rbn.Location = new System.Drawing.Point(10, 30);
            this.Option5_Rbn.Name = "Option5_Rbn";
            this.Option5_Rbn.Size = new System.Drawing.Size(73, 20);
            this.Option5_Rbn.TabIndex = 31;
            this.Option5_Rbn.TabStop = true;
            this.Option5_Rbn.Text = "일반 검색";
            this.Option5_Rbn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Option5_Rbn);
            this.groupBox2.Controls.Add(this.Option2_Rbn);
            this.groupBox2.Controls.Add(this.Option1_Rbn);
            this.groupBox2.Controls.Add(this.Option4_Rbn);
            this.groupBox2.Controls.Add(this.Option3_Rbn);
            this.groupBox2.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox2.Location = new System.Drawing.Point(5, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 195);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "구글 검색 연산자";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.Search_Tbx);
            this.groupBox3.ForeColor = System.Drawing.Color.BlueViolet;
            this.groupBox3.Location = new System.Drawing.Point(5, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 122);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "검색 옵션";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel3.Location = new System.Drawing.Point(20, 670);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 1);
            this.panel3.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1411, 766);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Search_Btn);
            this.Controls.Add(this.Video_Lbx);
            this.Controls.Add(this.Search_Lbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "GoogleSearch";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

    }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Search_Tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox Search_Lbx;
        private System.Windows.Forms.ListBox Video_Lbx;
        private System.Windows.Forms.Button Search_Btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Option1_Rbn;
        private System.Windows.Forms.RadioButton Option2_Rbn;
        private System.Windows.Forms.RadioButton Option3_Rbn;
        private System.Windows.Forms.RadioButton Option4_Rbn;
        private System.Windows.Forms.RadioButton Option5_Rbn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel3;
    }
}

