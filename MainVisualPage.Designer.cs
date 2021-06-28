namespace DWSerialPortSniffer
{
    partial class MainVisualPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainVisualPage));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.BTNInitConnection = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BaudrateB = new System.Windows.Forms.ComboBox();
            this.BaudrateA = new System.Windows.Forms.ComboBox();
            this.portnameB = new System.Windows.Forms.ComboBox();
            this.portnameA = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(848, 455);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.BTNInitConnection);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BaudrateB);
            this.panel1.Controls.Add(this.BaudrateA);
            this.panel1.Controls.Add(this.portnameB);
            this.panel1.Controls.Add(this.portnameA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 455);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 63);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 21);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ClearConsole);
            // 
            // BTNInitConnection
            // 
            this.BTNInitConnection.Location = new System.Drawing.Point(387, 4);
            this.BTNInitConnection.Name = "BTNInitConnection";
            this.BTNInitConnection.Size = new System.Drawing.Size(72, 21);
            this.BTNInitConnection.TabIndex = 2;
            this.BTNInitConnection.Text = "Start Sniff";
            this.BTNInitConnection.UseVisualStyleBackColor = true;
            this.BTNInitConnection.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Baudrate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Baudrate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port A";
            // 
            // BaudrateB
            // 
            this.BaudrateB.FormattingEnabled = true;
            this.BaudrateB.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "921600"});
            this.BaudrateB.Location = new System.Drawing.Point(276, 32);
            this.BaudrateB.Name = "BaudrateB";
            this.BaudrateB.Size = new System.Drawing.Size(80, 21);
            this.BaudrateB.TabIndex = 0;
            // 
            // BaudrateA
            // 
            this.BaudrateA.FormattingEnabled = true;
            this.BaudrateA.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "921600"});
            this.BaudrateA.Location = new System.Drawing.Point(75, 32);
            this.BaudrateA.Name = "BaudrateA";
            this.BaudrateA.Size = new System.Drawing.Size(80, 21);
            this.BaudrateA.TabIndex = 0;
            // 
            // portnameB
            // 
            this.portnameB.FormattingEnabled = true;
            this.portnameB.Location = new System.Drawing.Point(276, 5);
            this.portnameB.Name = "portnameB";
            this.portnameB.Size = new System.Drawing.Size(80, 21);
            this.portnameB.TabIndex = 0;
            // 
            // portnameA
            // 
            this.portnameA.FormattingEnabled = true;
            this.portnameA.Location = new System.Drawing.Point(75, 5);
            this.portnameA.Name = "portnameA";
            this.portnameA.Size = new System.Drawing.Size(80, 21);
            this.portnameA.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(502, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 21);
            this.button3.TabIndex = 2;
            this.button3.Text = "Terminate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.TerminateSnife);
            // 
            // MainVisualPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 518);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainVisualPage";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox portnameA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BaudrateB;
        private System.Windows.Forms.ComboBox BaudrateA;
        private System.Windows.Forms.ComboBox portnameB;
        private System.Windows.Forms.Button BTNInitConnection;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

