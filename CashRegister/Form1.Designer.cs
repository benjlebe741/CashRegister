namespace CashRegister
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.item1Label = new System.Windows.Forms.Label();
            this.item2Label = new System.Windows.Forms.Label();
            this.item3Label = new System.Windows.Forms.Label();
            this.owedButton = new System.Windows.Forms.Button();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.numTimsInput = new System.Windows.Forms.TextBox();
            this.numBitsInput = new System.Windows.Forms.TextBox();
            this.numHortsInput = new System.Windows.Forms.TextBox();
            this.subTotalOutputLabel = new System.Windows.Forms.Label();
            this.taxOutputLabel = new System.Windows.Forms.Label();
            this.totalOutputLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.changeOutputLabel = new System.Windows.Forms.Label();
            this.reciptButton = new System.Windows.Forms.Button();
            this.reciptOutputLabel = new System.Windows.Forms.Label();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.newOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.titleLabel.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLabel.Location = new System.Drawing.Point(12, 7);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(691, 49);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Ye Olde Hortons";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item1Label
            // 
            this.item1Label.BackColor = System.Drawing.Color.DarkSlateGray;
            this.item1Label.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item1Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.item1Label.Location = new System.Drawing.Point(12, 63);
            this.item1Label.Name = "item1Label";
            this.item1Label.Size = new System.Drawing.Size(187, 41);
            this.item1Label.TabIndex = 1;
            this.item1Label.Text = "#Of Tims  :";
            this.item1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item2Label
            // 
            this.item2Label.BackColor = System.Drawing.Color.DarkSlateGray;
            this.item2Label.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item2Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.item2Label.Location = new System.Drawing.Point(12, 114);
            this.item2Label.Name = "item2Label";
            this.item2Label.Size = new System.Drawing.Size(187, 41);
            this.item2Label.TabIndex = 2;
            this.item2Label.Text = "#Of Bits    :";
            this.item2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item3Label
            // 
            this.item3Label.BackColor = System.Drawing.Color.DarkSlateGray;
            this.item3Label.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item3Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.item3Label.Location = new System.Drawing.Point(12, 165);
            this.item3Label.Name = "item3Label";
            this.item3Label.Size = new System.Drawing.Size(187, 41);
            this.item3Label.TabIndex = 3;
            this.item3Label.Text = "#O\' Horts  :";
            this.item3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // owedButton
            // 
            this.owedButton.Enabled = false;
            this.owedButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.owedButton.FlatAppearance.BorderSize = 2;
            this.owedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.owedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.owedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.owedButton.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.owedButton.ForeColor = System.Drawing.Color.Teal;
            this.owedButton.Location = new System.Drawing.Point(12, 220);
            this.owedButton.Name = "owedButton";
            this.owedButton.Size = new System.Drawing.Size(323, 82);
            this.owedButton.TabIndex = 4;
            this.owedButton.Text = "Wha\'do I Owe ya?";
            this.owedButton.UseVisualStyleBackColor = true;
            this.owedButton.Click += new System.EventHandler(this.owedButton_Click);
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.subTotalLabel.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subTotalLabel.Location = new System.Drawing.Point(12, 317);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(187, 41);
            this.subTotalLabel.TabIndex = 5;
            this.subTotalLabel.Text = "Sub-Total:";
            this.subTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxLabel
            // 
            this.taxLabel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.taxLabel.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taxLabel.Location = new System.Drawing.Point(12, 367);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(187, 41);
            this.taxLabel.TabIndex = 6;
            this.taxLabel.Text = "Tax          :";
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.totalLabel.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalLabel.Location = new System.Drawing.Point(12, 418);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(187, 41);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "Total        :";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numTimsInput
            // 
            this.numTimsInput.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTimsInput.Location = new System.Drawing.Point(205, 63);
            this.numTimsInput.Name = "numTimsInput";
            this.numTimsInput.Size = new System.Drawing.Size(130, 40);
            this.numTimsInput.TabIndex = 8;
            // 
            // numBitsInput
            // 
            this.numBitsInput.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBitsInput.Location = new System.Drawing.Point(205, 114);
            this.numBitsInput.Name = "numBitsInput";
            this.numBitsInput.Size = new System.Drawing.Size(130, 40);
            this.numBitsInput.TabIndex = 9;
            // 
            // numHortsInput
            // 
            this.numHortsInput.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHortsInput.Location = new System.Drawing.Point(205, 165);
            this.numHortsInput.Name = "numHortsInput";
            this.numHortsInput.Size = new System.Drawing.Size(130, 40);
            this.numHortsInput.TabIndex = 10;
            // 
            // subTotalOutputLabel
            // 
            this.subTotalOutputLabel.BackColor = System.Drawing.Color.MintCream;
            this.subTotalOutputLabel.Font = new System.Drawing.Font("Old English Text MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalOutputLabel.ForeColor = System.Drawing.Color.Teal;
            this.subTotalOutputLabel.Location = new System.Drawing.Point(205, 317);
            this.subTotalOutputLabel.Name = "subTotalOutputLabel";
            this.subTotalOutputLabel.Size = new System.Drawing.Size(130, 41);
            this.subTotalOutputLabel.TabIndex = 11;
            this.subTotalOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxOutputLabel
            // 
            this.taxOutputLabel.BackColor = System.Drawing.Color.MintCream;
            this.taxOutputLabel.Font = new System.Drawing.Font("Old English Text MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutputLabel.ForeColor = System.Drawing.Color.Teal;
            this.taxOutputLabel.Location = new System.Drawing.Point(205, 367);
            this.taxOutputLabel.Name = "taxOutputLabel";
            this.taxOutputLabel.Size = new System.Drawing.Size(130, 41);
            this.taxOutputLabel.TabIndex = 12;
            this.taxOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalOutputLabel
            // 
            this.totalOutputLabel.BackColor = System.Drawing.Color.MintCream;
            this.totalOutputLabel.Font = new System.Drawing.Font("Old English Text MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutputLabel.ForeColor = System.Drawing.Color.Teal;
            this.totalOutputLabel.Location = new System.Drawing.Point(205, 420);
            this.totalOutputLabel.Name = "totalOutputLabel";
            this.totalOutputLabel.Size = new System.Drawing.Size(130, 41);
            this.totalOutputLabel.TabIndex = 13;
            this.totalOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeButton
            // 
            this.changeButton.Enabled = false;
            this.changeButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.changeButton.FlatAppearance.BorderSize = 2;
            this.changeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.changeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.Color.Teal;
            this.changeButton.Location = new System.Drawing.Point(12, 531);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(323, 82);
            this.changeButton.TabIndex = 14;
            this.changeButton.Text = "Wha\'cha gonna give me?";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 49);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tendered   :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tenderedInput
            // 
            this.tenderedInput.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedInput.Location = new System.Drawing.Point(205, 471);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(130, 40);
            this.tenderedInput.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 628);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 41);
            this.label2.TabIndex = 17;
            this.label2.Text = "Change     :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeOutputLabel
            // 
            this.changeOutputLabel.BackColor = System.Drawing.Color.MintCream;
            this.changeOutputLabel.Font = new System.Drawing.Font("Old English Text MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutputLabel.ForeColor = System.Drawing.Color.Teal;
            this.changeOutputLabel.Location = new System.Drawing.Point(205, 628);
            this.changeOutputLabel.Name = "changeOutputLabel";
            this.changeOutputLabel.Size = new System.Drawing.Size(130, 41);
            this.changeOutputLabel.TabIndex = 18;
            this.changeOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reciptButton
            // 
            this.reciptButton.Enabled = false;
            this.reciptButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.reciptButton.FlatAppearance.BorderSize = 2;
            this.reciptButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.reciptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.reciptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reciptButton.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciptButton.ForeColor = System.Drawing.Color.Teal;
            this.reciptButton.Location = new System.Drawing.Point(12, 685);
            this.reciptButton.Name = "reciptButton";
            this.reciptButton.Size = new System.Drawing.Size(323, 82);
            this.reciptButton.TabIndex = 19;
            this.reciptButton.Text = "Prove it >:(";
            this.reciptButton.UseVisualStyleBackColor = true;
            this.reciptButton.Click += new System.EventHandler(this.reciptButton_Click);
            // 
            // reciptOutputLabel
            // 
            this.reciptOutputLabel.BackColor = System.Drawing.Color.MintCream;
            this.reciptOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reciptOutputLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reciptOutputLabel.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciptOutputLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.reciptOutputLabel.Location = new System.Drawing.Point(350, 63);
            this.reciptOutputLabel.Name = "reciptOutputLabel";
            this.reciptOutputLabel.Size = new System.Drawing.Size(353, 61);
            this.reciptOutputLabel.TabIndex = 20;
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // newOrderButton
            // 
            this.newOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.newOrderButton.FlatAppearance.BorderSize = 2;
            this.newOrderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.newOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderButton.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.ForeColor = System.Drawing.Color.Teal;
            this.newOrderButton.Location = new System.Drawing.Point(350, 723);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(353, 44);
            this.newOrderButton.TabIndex = 21;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 784);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.reciptOutputLabel);
            this.Controls.Add(this.reciptButton);
            this.Controls.Add(this.changeOutputLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.totalOutputLabel);
            this.Controls.Add(this.taxOutputLabel);
            this.Controls.Add(this.subTotalOutputLabel);
            this.Controls.Add(this.numHortsInput);
            this.Controls.Add(this.numBitsInput);
            this.Controls.Add(this.numTimsInput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.owedButton);
            this.Controls.Add(this.item3Label);
            this.Controls.Add(this.item2Label);
            this.Controls.Add(this.item1Label);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label item1Label;
        private System.Windows.Forms.Label item2Label;
        private System.Windows.Forms.Label item3Label;
        private System.Windows.Forms.Button owedButton;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox numTimsInput;
        private System.Windows.Forms.TextBox numBitsInput;
        private System.Windows.Forms.TextBox numHortsInput;
        private System.Windows.Forms.Label subTotalOutputLabel;
        private System.Windows.Forms.Label taxOutputLabel;
        private System.Windows.Forms.Label totalOutputLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label changeOutputLabel;
        private System.Windows.Forms.Button reciptButton;
        private System.Windows.Forms.Label reciptOutputLabel;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Button newOrderButton;
    }
}

