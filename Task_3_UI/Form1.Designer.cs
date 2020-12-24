namespace Task_3_UI
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.DoorButton = new System.Windows.Forms.Button();
            this.WindowButton = new System.Windows.Forms.Button();
            this.AddDoor = new System.Windows.Forms.Button();
            this.AddWindow = new System.Windows.Forms.Button();
            this.doorMaterial = new System.Windows.Forms.TextBox();
            this.leavesAmount = new System.Windows.Forms.TextBox();
            this.windowType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(325, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 37);
            this.textBox1.TabIndex = 1;
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(43, 128);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(85, 39);
            this.OpenButton.TabIndex = 2;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(43, 173);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(85, 39);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DoorButton
            // 
            this.DoorButton.Location = new System.Drawing.Point(43, 263);
            this.DoorButton.Name = "DoorButton";
            this.DoorButton.Size = new System.Drawing.Size(85, 39);
            this.DoorButton.TabIndex = 4;
            this.DoorButton.Text = "Show Door Amount\r\n";
            this.DoorButton.UseVisualStyleBackColor = true;
            this.DoorButton.Click += new System.EventHandler(this.DoorButton_Click);
            // 
            // WindowButton
            // 
            this.WindowButton.Location = new System.Drawing.Point(43, 218);
            this.WindowButton.Name = "WindowButton";
            this.WindowButton.Size = new System.Drawing.Size(85, 39);
            this.WindowButton.TabIndex = 5;
            this.WindowButton.Text = "Show Windows Amount";
            this.WindowButton.UseVisualStyleBackColor = true;
            this.WindowButton.Click += new System.EventHandler(this.WindowButton_Click);
            // 
            // AddDoor
            // 
            this.AddDoor.Location = new System.Drawing.Point(297, 128);
            this.AddDoor.Name = "AddDoor";
            this.AddDoor.Size = new System.Drawing.Size(85, 39);
            this.AddDoor.TabIndex = 6;
            this.AddDoor.Text = "Add Door";
            this.AddDoor.UseVisualStyleBackColor = true;
            this.AddDoor.Click += new System.EventHandler(this.AddDoor_Click);
            // 
            // AddWindow
            // 
            this.AddWindow.Location = new System.Drawing.Point(537, 236);
            this.AddWindow.Name = "AddWindow";
            this.AddWindow.Size = new System.Drawing.Size(85, 39);
            this.AddWindow.TabIndex = 7;
            this.AddWindow.Text = "Add Window";
            this.AddWindow.UseVisualStyleBackColor = true;
            this.AddWindow.Click += new System.EventHandler(this.AddWindow_Click);
            // 
            // doorMaterial
            // 
            this.doorMaterial.Location = new System.Drawing.Point(297, 73);
            this.doorMaterial.Multiline = true;
            this.doorMaterial.Name = "doorMaterial";
            this.doorMaterial.Size = new System.Drawing.Size(145, 33);
            this.doorMaterial.TabIndex = 8;
            // 
            // leavesAmount
            // 
            this.leavesAmount.Location = new System.Drawing.Point(520, 73);
            this.leavesAmount.Multiline = true;
            this.leavesAmount.Name = "leavesAmount";
            this.leavesAmount.Size = new System.Drawing.Size(121, 35);
            this.leavesAmount.TabIndex = 9;
            // 
            // windowType
            // 
            this.windowType.Location = new System.Drawing.Point(520, 138);
            this.windowType.Multiline = true;
            this.windowType.Name = "windowType";
            this.windowType.Size = new System.Drawing.Size(121, 35);
            this.windowType.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.windowType);
            this.Controls.Add(this.leavesAmount);
            this.Controls.Add(this.doorMaterial);
            this.Controls.Add(this.AddWindow);
            this.Controls.Add(this.AddDoor);
            this.Controls.Add(this.WindowButton);
            this.Controls.Add(this.DoorButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox doorMaterial;

        private System.Windows.Forms.TextBox leavesAmount;
        private System.Windows.Forms.TextBox windowType;

        private System.Windows.Forms.Button AddWindow;

        private System.Windows.Forms.Button AddDoor;

        private System.Windows.Forms.Button WindowButton;

        private System.Windows.Forms.Button DoorButton;

        private System.Windows.Forms.Button CloseButton;

        private System.Windows.Forms.Button OpenButton;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}