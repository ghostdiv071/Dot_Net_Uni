namespace Task_6_UI
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
            this.TransportList = new System.Windows.Forms.ListBox();
            this.Route = new System.Windows.Forms.TextBox();
            this.Seats = new System.Windows.Forms.TextBox();
            this.Depot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.OutputField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddTramButton = new System.Windows.Forms.Button();
            this.BrokeButton = new System.Windows.Forms.Button();
            this.AddPassButton = new System.Windows.Forms.Button();
            this.Voltage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TransportList
            // 
            this.TransportList.FormattingEnabled = true;
            this.TransportList.Location = new System.Drawing.Point(12, 12);
            this.TransportList.Name = "TransportList";
            this.TransportList.Size = new System.Drawing.Size(333, 407);
            this.TransportList.TabIndex = 0;
            // 
            // Route
            // 
            this.Route.Location = new System.Drawing.Point(410, 35);
            this.Route.Name = "Route";
            this.Route.Size = new System.Drawing.Size(139, 20);
            this.Route.TabIndex = 1;
            // 
            // Seats
            // 
            this.Seats.Location = new System.Drawing.Point(410, 99);
            this.Seats.Name = "Seats";
            this.Seats.Size = new System.Drawing.Size(139, 20);
            this.Seats.TabIndex = 2;
            // 
            // Depot
            // 
            this.Depot.Location = new System.Drawing.Point(410, 156);
            this.Depot.Name = "Depot";
            this.Depot.Size = new System.Drawing.Size(139, 20);
            this.Depot.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(16, 71);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(89, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // OutputField
            // 
            this.OutputField.Location = new System.Drawing.Point(410, 374);
            this.OutputField.Multiline = true;
            this.OutputField.Name = "OutputField";
            this.OutputField.Size = new System.Drawing.Size(213, 45);
            this.OutputField.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(410, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Route Name\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(410, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Seats Number\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(410, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Depot";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddTramButton
            // 
            this.AddTramButton.Location = new System.Drawing.Point(626, 29);
            this.AddTramButton.Name = "AddTramButton";
            this.AddTramButton.Size = new System.Drawing.Size(108, 25);
            this.AddTramButton.TabIndex = 10;
            this.AddTramButton.Text = "Add new transport";
            this.AddTramButton.UseVisualStyleBackColor = true;
            this.AddTramButton.Click += new System.EventHandler(this.AddTramButton_Click);
            // 
            // BrokeButton
            // 
            this.BrokeButton.Location = new System.Drawing.Point(626, 94);
            this.BrokeButton.Name = "BrokeButton";
            this.BrokeButton.Size = new System.Drawing.Size(108, 25);
            this.BrokeButton.TabIndex = 11;
            this.BrokeButton.Text = "Broke\r\n";
            this.BrokeButton.UseVisualStyleBackColor = true;
            this.BrokeButton.Click += new System.EventHandler(this.BrokeButton_Click);
            // 
            // AddPassButton
            // 
            this.AddPassButton.Location = new System.Drawing.Point(626, 156);
            this.AddPassButton.Name = "AddPassButton";
            this.AddPassButton.Size = new System.Drawing.Size(108, 25);
            this.AddPassButton.TabIndex = 12;
            this.AddPassButton.Text = "Move";
            this.AddPassButton.UseVisualStyleBackColor = true;
            this.AddPassButton.Click += new System.EventHandler(this.AddPassButton_Click);
            // 
            // Voltage
            // 
            this.Voltage.Location = new System.Drawing.Point(410, 212);
            this.Voltage.Name = "Voltage";
            this.Voltage.Size = new System.Drawing.Size(139, 20);
            this.Voltage.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(410, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Voltage";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Voltage);
            this.Controls.Add(this.AddPassButton);
            this.Controls.Add(this.BrokeButton);
            this.Controls.Add(this.AddTramButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OutputField);
            this.Controls.Add(this.Depot);
            this.Controls.Add(this.Seats);
            this.Controls.Add(this.Route);
            this.Controls.Add(this.TransportList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox Seats;
        private System.Windows.Forms.TextBox Voltage;

        private System.Windows.Forms.TextBox Depot;

        private System.Windows.Forms.TextBox Route;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button AddPassButton;
        private System.Windows.Forms.Button AddTramButton;
        private System.Windows.Forms.Button BrokeButton;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox OutputField;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;


        private System.Windows.Forms.ListBox TransportList;

        #endregion
    }
}