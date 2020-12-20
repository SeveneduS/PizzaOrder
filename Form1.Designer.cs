
namespace PizzaOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.calculateButton = new System.Windows.Forms.Button();
            this.pizzaTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pizzaAmountUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.orderAddButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.orderListBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaAmountUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.calculateButton.BackColor = System.Drawing.Color.Teal;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.calculateButton.Location = new System.Drawing.Point(707, 641);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(116, 48);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // pizzaTypeComboBox
            // 
            this.pizzaTypeComboBox.FormattingEnabled = true;
            this.pizzaTypeComboBox.Location = new System.Drawing.Point(12, 33);
            this.pizzaTypeComboBox.Name = "pizzaTypeComboBox";
            this.pizzaTypeComboBox.Size = new System.Drawing.Size(811, 24);
            this.pizzaTypeComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Pizza Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Pizza Amount";
            // 
            // pizzaAmountUpDown
            // 
            this.pizzaAmountUpDown.Location = new System.Drawing.Point(12, 90);
            this.pizzaAmountUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.pizzaAmountUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pizzaAmountUpDown.Name = "pizzaAmountUpDown";
            this.pizzaAmountUpDown.Size = new System.Drawing.Size(120, 22);
            this.pizzaAmountUpDown.TabIndex = 5;
            this.pizzaAmountUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Order :";
            // 
            // orderAddButton
            // 
            this.orderAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.orderAddButton.Location = new System.Drawing.Point(12, 127);
            this.orderAddButton.Name = "orderAddButton";
            this.orderAddButton.Size = new System.Drawing.Size(163, 57);
            this.orderAddButton.TabIndex = 8;
            this.orderAddButton.Text = "Add To The Order";
            this.orderAddButton.UseVisualStyleBackColor = false;
            this.orderAddButton.Click += new System.EventHandler(this.AddPizza);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.removeButton.Location = new System.Drawing.Point(12, 190);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(162, 55);
            this.removeButton.TabIndex = 9;
            this.removeButton.Text = "Remove From The Order";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.RemovePizza);
            // 
            // orderListBox
            // 
            this.orderListBox.FormattingEnabled = true;
            this.orderListBox.Location = new System.Drawing.Point(181, 124);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.Size = new System.Drawing.Size(642, 497);
            this.orderListBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 641);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total : ";
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountLabel.Location = new System.Drawing.Point(277, 641);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(55, 25);
            this.totalAmountLabel.TabIndex = 12;
            this.totalAmountLabel.Text = "$ 0.0";
            this.totalAmountLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 701);
            this.Controls.Add(this.totalAmountLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.orderListBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.orderAddButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pizzaAmountUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pizzaTypeComboBox);
            this.Controls.Add(this.calculateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PizzaConfigurator";
            ((System.ComponentModel.ISupportInitialize)(this.pizzaAmountUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ComboBox pizzaTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown pizzaAmountUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button orderAddButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.CheckedListBox orderListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalAmountLabel;
    }
}

