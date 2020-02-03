namespace Stadium_Seating
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
            this.ticketsSoldGroupBox = new System.Windows.Forms.GroupBox();
            this.numberOfTicketsSoldLabel = new System.Windows.Forms.Label();
            this.classALabel = new System.Windows.Forms.Label();
            this.classBLabel = new System.Windows.Forms.Label();
            this.classCLabel = new System.Windows.Forms.Label();
            this.classATextBox = new System.Windows.Forms.TextBox();
            this.classBTextBox = new System.Windows.Forms.TextBox();
            this.classCTextBox = new System.Windows.Forms.TextBox();
            this.revenueGeneratedGroupBox = new System.Windows.Forms.GroupBox();
            this.revenueClassALabel = new System.Windows.Forms.Label();
            this.revenueClassBLabel = new System.Windows.Forms.Label();
            this.revenueClassCLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.classACalculatedLabel = new System.Windows.Forms.Label();
            this.classBCalculatedLabel = new System.Windows.Forms.Label();
            this.classCCalculatedLabel = new System.Windows.Forms.Label();
            this.totalCalculatedLabel = new System.Windows.Forms.Label();
            this.calculatedRevenueButton = new System.Windows.Forms.Button();
            this.clearDataButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.ticketsSoldGroupBox.SuspendLayout();
            this.revenueGeneratedGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ticketsSoldGroupBox
            // 
            this.ticketsSoldGroupBox.Controls.Add(this.classCTextBox);
            this.ticketsSoldGroupBox.Controls.Add(this.classBTextBox);
            this.ticketsSoldGroupBox.Controls.Add(this.classATextBox);
            this.ticketsSoldGroupBox.Controls.Add(this.classCLabel);
            this.ticketsSoldGroupBox.Controls.Add(this.classBLabel);
            this.ticketsSoldGroupBox.Controls.Add(this.classALabel);
            this.ticketsSoldGroupBox.Controls.Add(this.numberOfTicketsSoldLabel);
            this.ticketsSoldGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketsSoldGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ticketsSoldGroupBox.Name = "ticketsSoldGroupBox";
            this.ticketsSoldGroupBox.Size = new System.Drawing.Size(363, 243);
            this.ticketsSoldGroupBox.TabIndex = 0;
            this.ticketsSoldGroupBox.TabStop = false;
            this.ticketsSoldGroupBox.Text = "Tickets Sold";
            this.ticketsSoldGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // numberOfTicketsSoldLabel
            // 
            this.numberOfTicketsSoldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfTicketsSoldLabel.Location = new System.Drawing.Point(46, 40);
            this.numberOfTicketsSoldLabel.Name = "numberOfTicketsSoldLabel";
            this.numberOfTicketsSoldLabel.Size = new System.Drawing.Size(245, 40);
            this.numberOfTicketsSoldLabel.TabIndex = 0;
            this.numberOfTicketsSoldLabel.Text = "Enter the number of tickets sold for each class of seats.";
            // 
            // classALabel
            // 
            this.classALabel.AutoSize = true;
            this.classALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classALabel.Location = new System.Drawing.Point(71, 101);
            this.classALabel.Name = "classALabel";
            this.classALabel.Size = new System.Drawing.Size(67, 20);
            this.classALabel.TabIndex = 1;
            this.classALabel.Text = "Class A:";
            // 
            // classBLabel
            // 
            this.classBLabel.AutoSize = true;
            this.classBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classBLabel.Location = new System.Drawing.Point(70, 140);
            this.classBLabel.Name = "classBLabel";
            this.classBLabel.Size = new System.Drawing.Size(67, 20);
            this.classBLabel.TabIndex = 2;
            this.classBLabel.Text = "Class B:";
            // 
            // classCLabel
            // 
            this.classCLabel.AutoSize = true;
            this.classCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classCLabel.Location = new System.Drawing.Point(70, 180);
            this.classCLabel.Name = "classCLabel";
            this.classCLabel.Size = new System.Drawing.Size(67, 20);
            this.classCLabel.TabIndex = 3;
            this.classCLabel.Text = "Class C:";
            // 
            // classATextBox
            // 
            this.classATextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classATextBox.Location = new System.Drawing.Point(159, 101);
            this.classATextBox.Name = "classATextBox";
            this.classATextBox.Size = new System.Drawing.Size(152, 26);
            this.classATextBox.TabIndex = 4;
            this.classATextBox.TextChanged += new System.EventHandler(this.classATextBox_TextChanged);
            // 
            // classBTextBox
            // 
            this.classBTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classBTextBox.Location = new System.Drawing.Point(159, 137);
            this.classBTextBox.Name = "classBTextBox";
            this.classBTextBox.Size = new System.Drawing.Size(152, 26);
            this.classBTextBox.TabIndex = 5;
            this.classBTextBox.TextChanged += new System.EventHandler(this.classBTextBox_TextChanged);
            // 
            // classCTextBox
            // 
            this.classCTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classCTextBox.Location = new System.Drawing.Point(159, 174);
            this.classCTextBox.Name = "classCTextBox";
            this.classCTextBox.Size = new System.Drawing.Size(152, 26);
            this.classCTextBox.TabIndex = 6;
            this.classCTextBox.TextChanged += new System.EventHandler(this.classCTextBox_TextChanged);
            // 
            // revenueGeneratedGroupBox
            // 
            this.revenueGeneratedGroupBox.Controls.Add(this.totalCalculatedLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.classCCalculatedLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.classBCalculatedLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.classACalculatedLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.totalLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.revenueClassCLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.revenueClassBLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.revenueClassALabel);
            this.revenueGeneratedGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueGeneratedGroupBox.Location = new System.Drawing.Point(432, 12);
            this.revenueGeneratedGroupBox.Name = "revenueGeneratedGroupBox";
            this.revenueGeneratedGroupBox.Size = new System.Drawing.Size(356, 243);
            this.revenueGeneratedGroupBox.TabIndex = 1;
            this.revenueGeneratedGroupBox.TabStop = false;
            this.revenueGeneratedGroupBox.Text = "Revenue Generated";
            // 
            // revenueClassALabel
            // 
            this.revenueClassALabel.AutoSize = true;
            this.revenueClassALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueClassALabel.Location = new System.Drawing.Point(19, 60);
            this.revenueClassALabel.Name = "revenueClassALabel";
            this.revenueClassALabel.Size = new System.Drawing.Size(67, 20);
            this.revenueClassALabel.TabIndex = 0;
            this.revenueClassALabel.Text = "Class A:";
            // 
            // revenueClassBLabel
            // 
            this.revenueClassBLabel.AutoSize = true;
            this.revenueClassBLabel.Location = new System.Drawing.Point(19, 101);
            this.revenueClassBLabel.Name = "revenueClassBLabel";
            this.revenueClassBLabel.Size = new System.Drawing.Size(67, 20);
            this.revenueClassBLabel.TabIndex = 1;
            this.revenueClassBLabel.Text = "Class B:";
            // 
            // revenueClassCLabel
            // 
            this.revenueClassCLabel.AutoSize = true;
            this.revenueClassCLabel.Location = new System.Drawing.Point(19, 140);
            this.revenueClassCLabel.Name = "revenueClassCLabel";
            this.revenueClassCLabel.Size = new System.Drawing.Size(67, 20);
            this.revenueClassCLabel.TabIndex = 2;
            this.revenueClassCLabel.Text = "Class C:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(38, 174);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 20);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "Total:";
            // 
            // classACalculatedLabel
            // 
            this.classACalculatedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classACalculatedLabel.Location = new System.Drawing.Point(107, 60);
            this.classACalculatedLabel.Name = "classACalculatedLabel";
            this.classACalculatedLabel.Size = new System.Drawing.Size(229, 23);
            this.classACalculatedLabel.TabIndex = 4;
            this.classACalculatedLabel.Click += new System.EventHandler(this.classACalculatedLabel_Click);
            // 
            // classBCalculatedLabel
            // 
            this.classBCalculatedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classBCalculatedLabel.Location = new System.Drawing.Point(107, 98);
            this.classBCalculatedLabel.Name = "classBCalculatedLabel";
            this.classBCalculatedLabel.Size = new System.Drawing.Size(229, 23);
            this.classBCalculatedLabel.TabIndex = 5;
            this.classBCalculatedLabel.Click += new System.EventHandler(this.classBCalculatedLabel_Click);
            // 
            // classCCalculatedLabel
            // 
            this.classCCalculatedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classCCalculatedLabel.Location = new System.Drawing.Point(107, 137);
            this.classCCalculatedLabel.Name = "classCCalculatedLabel";
            this.classCCalculatedLabel.Size = new System.Drawing.Size(229, 23);
            this.classCCalculatedLabel.TabIndex = 6;
            // 
            // totalCalculatedLabel
            // 
            this.totalCalculatedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCalculatedLabel.Location = new System.Drawing.Point(107, 174);
            this.totalCalculatedLabel.Name = "totalCalculatedLabel";
            this.totalCalculatedLabel.Size = new System.Drawing.Size(229, 23);
            this.totalCalculatedLabel.TabIndex = 7;
            // 
            // calculatedRevenueButton
            // 
            this.calculatedRevenueButton.Location = new System.Drawing.Point(138, 313);
            this.calculatedRevenueButton.Name = "calculatedRevenueButton";
            this.calculatedRevenueButton.Size = new System.Drawing.Size(126, 68);
            this.calculatedRevenueButton.TabIndex = 2;
            this.calculatedRevenueButton.Text = "Calculated Revenue";
            this.calculatedRevenueButton.UseVisualStyleBackColor = true;
            this.calculatedRevenueButton.Click += new System.EventHandler(this.calculatedRevenueButton_Click);
            // 
            // clearDataButton
            // 
            this.clearDataButton.Location = new System.Drawing.Point(336, 313);
            this.clearDataButton.Name = "clearDataButton";
            this.clearDataButton.Size = new System.Drawing.Size(135, 68);
            this.clearDataButton.TabIndex = 3;
            this.clearDataButton.Text = "Clear";
            this.clearDataButton.UseVisualStyleBackColor = true;
            this.clearDataButton.Click += new System.EventHandler(this.clearDataButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(539, 313);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 68);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearDataButton);
            this.Controls.Add(this.calculatedRevenueButton);
            this.Controls.Add(this.revenueGeneratedGroupBox);
            this.Controls.Add(this.ticketsSoldGroupBox);
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.ticketsSoldGroupBox.ResumeLayout(false);
            this.ticketsSoldGroupBox.PerformLayout();
            this.revenueGeneratedGroupBox.ResumeLayout(false);
            this.revenueGeneratedGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ticketsSoldGroupBox;
        private System.Windows.Forms.Label numberOfTicketsSoldLabel;
        private System.Windows.Forms.TextBox classCTextBox;
        private System.Windows.Forms.TextBox classBTextBox;
        private System.Windows.Forms.TextBox classATextBox;
        private System.Windows.Forms.Label classCLabel;
        private System.Windows.Forms.Label classBLabel;
        private System.Windows.Forms.Label classALabel;
        private System.Windows.Forms.GroupBox revenueGeneratedGroupBox;
        private System.Windows.Forms.Label classCCalculatedLabel;
        private System.Windows.Forms.Label classBCalculatedLabel;
        private System.Windows.Forms.Label classACalculatedLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label revenueClassCLabel;
        private System.Windows.Forms.Label revenueClassBLabel;
        private System.Windows.Forms.Label revenueClassALabel;
        private System.Windows.Forms.Label totalCalculatedLabel;
        private System.Windows.Forms.Button calculatedRevenueButton;
        private System.Windows.Forms.Button clearDataButton;
        private System.Windows.Forms.Button exitButton;
    }
}

