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
            this.buttonValveOn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPomp = new System.Windows.Forms.Label();
            this.labelValve = new System.Windows.Forms.Label();
            this.buttonSerialConnect = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonPompOn
            // 
            this.buttonPompOn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonPompOn.Location = new System.Drawing.Point(12, 51);
            this.buttonPompOn.Name = "buttonPompOn";
            this.buttonPompOn.Size = new System.Drawing.Size(120, 50);
            this.buttonPompOn.TabIndex = 0;
            this.buttonPompOn.Text = "Pomp ON";
            this.buttonPompOn.UseVisualStyleBackColor = true;
            this.buttonPompOn.Click += new System.EventHandler(this.buttonPompOn_Click);
            // 
            // buttonPompOff
            // 
            this.buttonPompOff.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonPompOff.Location = new System.Drawing.Point(12, 121);
            this.buttonPompOff.Name = "buttonPompOff";
            this.buttonPompOff.Size = new System.Drawing.Size(120, 50);
            this.buttonPompOff.TabIndex = 1;
            this.buttonPompOff.Text = "Pomp OFF";
            this.buttonPompOff.UseVisualStyleBackColor = true;
            // 
            // buttonValveOn
            // 
            this.buttonValveOn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonValveOn.Location = new System.Drawing.Point(152, 51);
            this.buttonValveOn.Name = "buttonValveOn";
            this.buttonValveOn.Size = new System.Drawing.Size(120, 50);
            this.buttonValveOn.TabIndex = 2;
            this.buttonValveOn.Text = "Valve OPEN";
            this.buttonValveOn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(152, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Valve CLOSE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelPomp
            // 
            this.labelPomp.AutoSize = true;
            this.labelPomp.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPomp.Location = new System.Drawing.Point(28, 196);
            this.labelPomp.Name = "labelPomp";
            this.labelPomp.Size = new System.Drawing.Size(93, 19);
            this.labelPomp.TabIndex = 4;
            this.labelPomp.Text = "Pomp OFF";
            this.labelPomp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValve
            // 
            this.labelValve.AutoSize = true;
            this.labelValve.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelValve.Location = new System.Drawing.Point(148, 196);
            this.labelValve.Name = "labelValve";
            this.labelValve.Size = new System.Drawing.Size(117, 19);
            this.labelValve.TabIndex = 5;
            this.labelValve.Text = "Valve CLOSE";
            this.labelValve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSerialConnect
            // 
            this.buttonSerialConnect.Location = new System.Drawing.Point(12, 12);
            this.buttonSerialConnect.Name = "buttonSerialConnect";
            this.buttonSerialConnect.Size = new System.Drawing.Size(120, 23);
            this.buttonSerialConnect.TabIndex = 6;
            this.buttonSerialConnect.Text = "シリアル通信接続";
            this.buttonSerialConnect.UseVisualStyleBackColor = true;
            this.buttonSerialConnect.Click += new System.EventHandler(this.buttonSerialConnect_Click);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(152, 15);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 19);
            this.textBoxPort.TabIndex = 7;
            this.textBoxPort.Text = "COM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.buttonSerialConnect);
            this.Controls.Add(this.labelValve);
            this.Controls.Add(this.labelPomp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonValveOn);
            this.Controls.Add(this.buttonPompOff);
            this.Controls.Add(this.buttonPompOn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPompOn;
        private System.Windows.Forms.Button buttonPompOff;
        private System.Windows.Forms.Button buttonValveOn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPomp;
        private System.Windows.Forms.Label labelValve;
        private System.Windows.Forms.Button buttonSerialConnect;
        private System.Windows.Forms.TextBox textBoxPort;
    }
}

