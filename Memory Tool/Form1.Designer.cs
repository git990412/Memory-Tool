namespace Memory_Tool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelprocessname = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelpid = new System.Windows.Forms.Label();
            this.labelhandle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textboxreadparm = new System.Windows.Forms.TextBox();
            this.textboxshowadress = new System.Windows.Forms.TextBox();
            this.textboxShow4bytetoint = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxShow1Bytetoint = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxShow2Bytetoint = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxShow3Bytetoint = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxShow5Bytetoint = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textboxShowfloat = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Dwordwrite = new System.Windows.Forms.TextBox();
            this.writefloattextbox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.writedword = new System.Windows.Forms.Label();
            this.writefloat = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.writeinttextbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Read";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(455, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Write";
            // 
            // labelprocessname
            // 
            this.labelprocessname.AutoSize = true;
            this.labelprocessname.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelprocessname.Location = new System.Drawing.Point(232, 61);
            this.labelprocessname.Name = "labelprocessname";
            this.labelprocessname.Size = new System.Drawing.Size(90, 12);
            this.labelprocessname.TabIndex = 2;
            this.labelprocessname.Text = "Process Name";
            this.labelprocessname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "Process List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelpid
            // 
            this.labelpid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelpid.Location = new System.Drawing.Point(267, 21);
            this.labelpid.Name = "labelpid";
            this.labelpid.Size = new System.Drawing.Size(23, 12);
            this.labelpid.TabIndex = 4;
            this.labelpid.Text = "Pid";
            this.labelpid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelpid.Visible = false;
            // 
            // labelhandle
            // 
            this.labelhandle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelhandle.AutoSize = true;
            this.labelhandle.Location = new System.Drawing.Point(256, 45);
            this.labelhandle.Name = "labelhandle";
            this.labelhandle.Size = new System.Drawing.Size(43, 12);
            this.labelhandle.TabIndex = 5;
            this.labelhandle.Text = "handle";
            this.labelhandle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelhandle.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(264, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pid";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(252, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "Handle";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textboxreadparm
            // 
            this.textboxreadparm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textboxreadparm.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textboxreadparm.Location = new System.Drawing.Point(78, 105);
            this.textboxreadparm.MaxLength = 8;
            this.textboxreadparm.Name = "textboxreadparm";
            this.textboxreadparm.Size = new System.Drawing.Size(100, 21);
            this.textboxreadparm.TabIndex = 7;
            this.textboxreadparm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxreadparm_KeyPress);
            // 
            // textboxshowadress
            // 
            this.textboxshowadress.Location = new System.Drawing.Point(78, 132);
            this.textboxshowadress.Name = "textboxshowadress";
            this.textboxshowadress.ReadOnly = true;
            this.textboxshowadress.Size = new System.Drawing.Size(100, 21);
            this.textboxshowadress.TabIndex = 7;
            // 
            // textboxShow4bytetoint
            // 
            this.textboxShow4bytetoint.Location = new System.Drawing.Point(78, 159);
            this.textboxShow4bytetoint.Name = "textboxShow4bytetoint";
            this.textboxShow4bytetoint.ReadOnly = true;
            this.textboxShow4bytetoint.Size = new System.Drawing.Size(100, 21);
            this.textboxShow4bytetoint.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "4Byte(Hex)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "4Byte(Int)";
            // 
            // textBoxShow1Bytetoint
            // 
            this.textBoxShow1Bytetoint.Location = new System.Drawing.Point(78, 186);
            this.textBoxShow1Bytetoint.Name = "textBoxShow1Bytetoint";
            this.textBoxShow1Bytetoint.ReadOnly = true;
            this.textBoxShow1Bytetoint.Size = new System.Drawing.Size(100, 21);
            this.textBoxShow1Bytetoint.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "1Byte(Int)";
            // 
            // textBoxShow2Bytetoint
            // 
            this.textBoxShow2Bytetoint.Location = new System.Drawing.Point(78, 213);
            this.textBoxShow2Bytetoint.Name = "textBoxShow2Bytetoint";
            this.textBoxShow2Bytetoint.ReadOnly = true;
            this.textBoxShow2Bytetoint.Size = new System.Drawing.Size(100, 21);
            this.textBoxShow2Bytetoint.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "2Byte(Int)";
            // 
            // textBoxShow3Bytetoint
            // 
            this.textBoxShow3Bytetoint.Location = new System.Drawing.Point(78, 240);
            this.textBoxShow3Bytetoint.Name = "textBoxShow3Bytetoint";
            this.textBoxShow3Bytetoint.ReadOnly = true;
            this.textBoxShow3Bytetoint.Size = new System.Drawing.Size(100, 21);
            this.textBoxShow3Bytetoint.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "3Byte(Int)";
            // 
            // textBoxShow5Bytetoint
            // 
            this.textBoxShow5Bytetoint.Location = new System.Drawing.Point(78, 267);
            this.textBoxShow5Bytetoint.Name = "textBoxShow5Bytetoint";
            this.textBoxShow5Bytetoint.ReadOnly = true;
            this.textBoxShow5Bytetoint.Size = new System.Drawing.Size(100, 21);
            this.textBoxShow5Bytetoint.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "4Byte(Int)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "Adress";
            // 
            // textboxShowfloat
            // 
            this.textboxShowfloat.Location = new System.Drawing.Point(78, 294);
            this.textboxShowfloat.Name = "textboxShowfloat";
            this.textboxShowfloat.ReadOnly = true;
            this.textboxShowfloat.Size = new System.Drawing.Size(100, 21);
            this.textboxShowfloat.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "Float";
            // 
            // Dwordwrite
            // 
            this.Dwordwrite.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Dwordwrite.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Dwordwrite.Location = new System.Drawing.Point(421, 105);
            this.Dwordwrite.MaxLength = 8;
            this.Dwordwrite.Name = "Dwordwrite";
            this.Dwordwrite.Size = new System.Drawing.Size(100, 21);
            this.Dwordwrite.TabIndex = 8;
            this.Dwordwrite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dwordwrite_KeyPress);
            // 
            // writefloattextbox
            // 
            this.writefloattextbox.Location = new System.Drawing.Point(421, 132);
            this.writefloattextbox.Name = "writefloattextbox";
            this.writefloattextbox.Size = new System.Drawing.Size(100, 21);
            this.writefloattextbox.TabIndex = 8;
            this.writefloattextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.writefloattextbox_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(421, 182);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(45, 21);
            this.textBox3.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(421, 209);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(45, 21);
            this.textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(421, 236);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(45, 21);
            this.textBox6.TabIndex = 8;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(421, 263);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(45, 21);
            this.textBox7.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(476, 182);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(45, 21);
            this.textBox4.TabIndex = 8;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(476, 209);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(45, 21);
            this.textBox8.TabIndex = 8;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(476, 236);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(45, 21);
            this.textBox9.TabIndex = 8;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(476, 263);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(45, 21);
            this.textBox10.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(421, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "▶";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(476, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "∞";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // writedword
            // 
            this.writedword.AutoSize = true;
            this.writedword.Location = new System.Drawing.Point(371, 110);
            this.writedword.Name = "writedword";
            this.writedword.Size = new System.Drawing.Size(41, 12);
            this.writedword.TabIndex = 10;
            this.writedword.Text = "Dword";
            // 
            // writefloat
            // 
            this.writefloat.AutoSize = true;
            this.writefloat.Location = new System.Drawing.Point(377, 136);
            this.writefloat.Name = "writefloat";
            this.writefloat.Size = new System.Drawing.Size(32, 12);
            this.writefloat.TabIndex = 10;
            this.writefloat.Text = "Float";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(371, 188);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 12);
            this.label15.TabIndex = 10;
            this.label15.Text = "label13";
            this.label15.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(371, 214);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 12);
            this.label16.TabIndex = 10;
            this.label16.Text = "label13";
            this.label16.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(371, 242);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 12);
            this.label17.TabIndex = 10;
            this.label17.Text = "label13";
            this.label17.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(371, 269);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 12);
            this.label18.TabIndex = 10;
            this.label18.Text = "label13";
            this.label18.Visible = false;
            // 
            // writeinttextbox
            // 
            this.writeinttextbox.Location = new System.Drawing.Point(421, 157);
            this.writeinttextbox.Name = "writeinttextbox";
            this.writeinttextbox.Size = new System.Drawing.Size(100, 21);
            this.writeinttextbox.TabIndex = 8;
            this.writeinttextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.writeinttextbox_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(390, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 12);
            this.label13.TabIndex = 10;
            this.label13.Text = "Int";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(239, 191);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Newform";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 328);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.writefloat);
            this.Controls.Add(this.writedword);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.writeinttextbox);
            this.Controls.Add(this.writefloattextbox);
            this.Controls.Add(this.Dwordwrite);
            this.Controls.Add(this.textboxShowfloat);
            this.Controls.Add(this.textBoxShow5Bytetoint);
            this.Controls.Add(this.textBoxShow3Bytetoint);
            this.Controls.Add(this.textBoxShow2Bytetoint);
            this.Controls.Add(this.textBoxShow1Bytetoint);
            this.Controls.Add(this.textboxShow4bytetoint);
            this.Controls.Add(this.textboxshowadress);
            this.Controls.Add(this.textboxreadparm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelhandle);
            this.Controls.Add(this.labelpid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelprocessname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Memory Tool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label labelpid;
        public System.Windows.Forms.Label labelhandle;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label labelprocessname;
        private System.Windows.Forms.TextBox textboxreadparm;
        private System.Windows.Forms.TextBox textboxshowadress;
        private System.Windows.Forms.TextBox textboxShow4bytetoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxShow1Bytetoint;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxShow2Bytetoint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxShow3Bytetoint;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxShow5Bytetoint;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textboxShowfloat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Dwordwrite;
        private System.Windows.Forms.TextBox writefloattextbox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label writedword;
        private System.Windows.Forms.Label writefloat;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox writeinttextbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
    }
}

