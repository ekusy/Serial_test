namespace SerialTest
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPompOn = new System.Windows.Forms.Button();
            this.buttonPompOff = new System.Windows.Forms.Button();
            this.buttonValveClose = new System.Windows.Forms.Button();
            this.buttonValveOpen = new System.Windows.Forms.Button();
            this.labelPomp = new System.Windows.Forms.Label();
            this.labelValve = new System.Windows.Forms.Label();
            this.buttonSerialConnect = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelConnect = new System.Windows.Forms.Label();
            this.buttonSerialClose = new System.Windows.Forms.Button();
            this.textBoxButton1 = new System.Windows.Forms.TextBox();
            this.textBoxButton3 = new System.Windows.Forms.TextBox();
            this.textBoxButton2 = new System.Windows.Forms.TextBox();
            this.textBoxButton4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonPompOn
            // 
            this.buttonPompOn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonPompOn.Location = new System.Drawing.Point(20, 114);
            this.buttonPompOn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonPompOn.Name = "buttonPompOn";
            this.buttonPompOn.Size = new System.Drawing.Size(200, 75);
            this.buttonPompOn.TabIndex = 0;
            this.buttonPompOn.Text = "Pomp ON";
            this.buttonPompOn.UseVisualStyleBackColor = true;
            this.buttonPompOn.Click += new System.EventHandler(this.buttonPompOn_Click);
            // 
            // buttonPompOff
            // 
            this.buttonPompOff.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonPompOff.Location = new System.Drawing.Point(20, 240);
            this.buttonPompOff.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonPompOff.Name = "buttonPompOff";
            this.buttonPompOff.Size = new System.Drawing.Size(200, 75);
            this.buttonPompOff.TabIndex = 1;
            this.buttonPompOff.Text = "Pomp OFF";
            this.buttonPompOff.UseVisualStyleBackColor = true;
            this.buttonPompOff.Click += new System.EventHandler(this.buttonPompOff_Click);
            // 
            // buttonValveClose
            // 
            this.buttonValveClose.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonValveClose.Location = new System.Drawing.Point(253, 114);
            this.buttonValveClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonValveClose.Name = "buttonValveClose";
            this.buttonValveClose.Size = new System.Drawing.Size(200, 75);
            this.buttonValveClose.TabIndex = 2;
            this.buttonValveClose.Text = "Valve CLOSE";
            this.buttonValveClose.UseVisualStyleBackColor = true;
            this.buttonValveClose.Click += new System.EventHandler(this.buttonValveClose_Click);
            // 
            // buttonValveOpen
            // 
            this.buttonValveOpen.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonValveOpen.Location = new System.Drawing.Point(253, 240);
            this.buttonValveOpen.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonValveOpen.Name = "buttonValveOpen";
            this.buttonValveOpen.Size = new System.Drawing.Size(200, 75);
            this.buttonValveOpen.TabIndex = 3;
            this.buttonValveOpen.Text = "Valve OPEN";
            this.buttonValveOpen.UseVisualStyleBackColor = true;
            this.buttonValveOpen.Click += new System.EventHandler(this.buttonValveOpen_Click);
            // 
            // labelPomp
            // 
            this.labelPomp.AutoSize = true;
            this.labelPomp.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPomp.Location = new System.Drawing.Point(47, 376);
            this.labelPomp.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPomp.Name = "labelPomp";
            this.labelPomp.Size = new System.Drawing.Size(143, 29);
            this.labelPomp.TabIndex = 4;
            this.labelPomp.Text = "Pomp OFF";
            this.labelPomp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValve
            // 
            this.labelValve.AutoSize = true;
            this.labelValve.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelValve.Location = new System.Drawing.Point(247, 376);
            this.labelValve.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelValve.Name = "labelValve";
            this.labelValve.Size = new System.Drawing.Size(178, 29);
            this.labelValve.TabIndex = 5;
            this.labelValve.Text = "Valve CLOSE";
            this.labelValve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSerialConnect
            // 
            this.buttonSerialConnect.Location = new System.Drawing.Point(20, 18);
            this.buttonSerialConnect.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonSerialConnect.Name = "buttonSerialConnect";
            this.buttonSerialConnect.Size = new System.Drawing.Size(200, 34);
            this.buttonSerialConnect.TabIndex = 6;
            this.buttonSerialConnect.Text = "シリアル通信接続";
            this.buttonSerialConnect.UseVisualStyleBackColor = true;
            this.buttonSerialConnect.Click += new System.EventHandler(this.buttonSerialConnect_Click);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(253, 22);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(164, 25);
            this.textBoxPort.TabIndex = 7;
            this.textBoxPort.Text = "COM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(20, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "接続先";
            // 
            // labelConnect
            // 
            this.labelConnect.AutoSize = true;
            this.labelConnect.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelConnect.Location = new System.Drawing.Point(127, 72);
            this.labelConnect.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelConnect.Name = "labelConnect";
            this.labelConnect.Size = new System.Drawing.Size(82, 24);
            this.labelConnect.TabIndex = 9;
            this.labelConnect.Text = "未接続";
            // 
            // buttonSerialClose
            // 
            this.buttonSerialClose.Location = new System.Drawing.Point(253, 60);
            this.buttonSerialClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonSerialClose.Name = "buttonSerialClose";
            this.buttonSerialClose.Size = new System.Drawing.Size(125, 34);
            this.buttonSerialClose.TabIndex = 10;
            this.buttonSerialClose.Text = "切断";
            this.buttonSerialClose.UseVisualStyleBackColor = true;
            this.buttonSerialClose.Click += new System.EventHandler(this.buttonSerialClose_Click);
            // 
            // textBoxButton1
            // 
            this.textBoxButton1.Location = new System.Drawing.Point(25, 200);
            this.textBoxButton1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxButton1.Name = "textBoxButton1";
            this.textBoxButton1.Size = new System.Drawing.Size(164, 25);
            this.textBoxButton1.TabIndex = 11;
            this.textBoxButton1.Text = "1";
            this.textBoxButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxButton3
            // 
            this.textBoxButton3.Location = new System.Drawing.Point(253, 202);
            this.textBoxButton3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxButton3.Name = "textBoxButton3";
            this.textBoxButton3.Size = new System.Drawing.Size(164, 25);
            this.textBoxButton3.TabIndex = 12;
            this.textBoxButton3.Text = "3";
            this.textBoxButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxButton2
            // 
            this.textBoxButton2.Location = new System.Drawing.Point(20, 324);
            this.textBoxButton2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxButton2.Name = "textBoxButton2";
            this.textBoxButton2.Size = new System.Drawing.Size(164, 25);
            this.textBoxButton2.TabIndex = 13;
            this.textBoxButton2.Text = "2";
            this.textBoxButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxButton4
            // 
            this.textBoxButton4.Location = new System.Drawing.Point(253, 324);
            this.textBoxButton4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxButton4.Name = "textBoxButton4";
            this.textBoxButton4.Size = new System.Drawing.Size(164, 25);
            this.textBoxButton4.TabIndex = 14;
            this.textBoxButton4.Text = "4";
            this.textBoxButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 466);
            this.Controls.Add(this.textBoxButton4);
            this.Controls.Add(this.textBoxButton2);
            this.Controls.Add(this.textBoxButton3);
            this.Controls.Add(this.textBoxButton1);
            this.Controls.Add(this.buttonSerialClose);
            this.Controls.Add(this.labelConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.buttonSerialConnect);
            this.Controls.Add(this.labelValve);
            this.Controls.Add(this.labelPomp);
            this.Controls.Add(this.buttonValveOpen);
            this.Controls.Add(this.buttonValveClose);
            this.Controls.Add(this.buttonPompOff);
            this.Controls.Add(this.buttonPompOn);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPompOn;
        private System.Windows.Forms.Button buttonPompOff;
        private System.Windows.Forms.Button buttonValveClose;
        private System.Windows.Forms.Button buttonValveOpen;
        private System.Windows.Forms.Label labelPomp;
        private System.Windows.Forms.Label labelValve;
        private System.Windows.Forms.Button buttonSerialConnect;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelConnect;
        private System.Windows.Forms.Button buttonSerialClose;
        private System.Windows.Forms.TextBox textBoxButton1;
        private System.Windows.Forms.TextBox textBoxButton3;
        private System.Windows.Forms.TextBox textBoxButton2;
        private System.Windows.Forms.TextBox textBoxButton4;
    }
}

