namespace SDA_7
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAgent = new System.Windows.Forms.Button();
            this.btnRemovePhone = new System.Windows.Forms.Button();
            this.btnAgentSearch = new System.Windows.Forms.Button();
            this.btnPhoneSearch = new System.Windows.Forms.Button();
            this.btnShowPhoneBook = new System.Windows.Forms.Button();
            this.btnCopyTo = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Служител";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Телефон";
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(145, 28);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(135, 20);
            this.tbValue.TabIndex = 2;
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(145, 63);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(135, 20);
            this.tbKey.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(298, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добави";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(298, 63);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(129, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Изтрий Служ + Тел";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAgent
            // 
            this.btnRemoveAgent.Location = new System.Drawing.Point(433, 28);
            this.btnRemoveAgent.Name = "btnRemoveAgent";
            this.btnRemoveAgent.Size = new System.Drawing.Size(129, 23);
            this.btnRemoveAgent.TabIndex = 6;
            this.btnRemoveAgent.Text = "Изтрий Служител";
            this.btnRemoveAgent.UseVisualStyleBackColor = true;
            this.btnRemoveAgent.Click += new System.EventHandler(this.btnRemoveAgent_Click);
            // 
            // btnRemovePhone
            // 
            this.btnRemovePhone.Location = new System.Drawing.Point(433, 63);
            this.btnRemovePhone.Name = "btnRemovePhone";
            this.btnRemovePhone.Size = new System.Drawing.Size(129, 23);
            this.btnRemovePhone.TabIndex = 7;
            this.btnRemovePhone.Text = "Изтрий Телефон";
            this.btnRemovePhone.UseVisualStyleBackColor = true;
            this.btnRemovePhone.Click += new System.EventHandler(this.btnRemovePhone_Click);
            // 
            // btnAgentSearch
            // 
            this.btnAgentSearch.Location = new System.Drawing.Point(568, 28);
            this.btnAgentSearch.Name = "btnAgentSearch";
            this.btnAgentSearch.Size = new System.Drawing.Size(129, 23);
            this.btnAgentSearch.TabIndex = 8;
            this.btnAgentSearch.Text = "Търси служител";
            this.btnAgentSearch.UseVisualStyleBackColor = true;
            this.btnAgentSearch.Click += new System.EventHandler(this.btnAgentSearch_Click);
            // 
            // btnPhoneSearch
            // 
            this.btnPhoneSearch.Location = new System.Drawing.Point(568, 63);
            this.btnPhoneSearch.Name = "btnPhoneSearch";
            this.btnPhoneSearch.Size = new System.Drawing.Size(129, 23);
            this.btnPhoneSearch.TabIndex = 9;
            this.btnPhoneSearch.Text = "Търси телефон";
            this.btnPhoneSearch.UseVisualStyleBackColor = true;
            this.btnPhoneSearch.Click += new System.EventHandler(this.btnPhoneSearch_Click);
            // 
            // btnShowPhoneBook
            // 
            this.btnShowPhoneBook.Location = new System.Drawing.Point(703, 28);
            this.btnShowPhoneBook.Name = "btnShowPhoneBook";
            this.btnShowPhoneBook.Size = new System.Drawing.Size(129, 23);
            this.btnShowPhoneBook.TabIndex = 10;
            this.btnShowPhoneBook.Text = "Телефонен  Указател";
            this.btnShowPhoneBook.UseVisualStyleBackColor = true;
            // 
            // btnCopyTo
            // 
            this.btnCopyTo.Location = new System.Drawing.Point(703, 63);
            this.btnCopyTo.Name = "btnCopyTo";
            this.btnCopyTo.Size = new System.Drawing.Size(129, 23);
            this.btnCopyTo.TabIndex = 11;
            this.btnCopyTo.Text = "CopyTo";
            this.btnCopyTo.UseVisualStyleBackColor = true;
            this.btnCopyTo.Click += new System.EventHandler(this.btnCopyTo_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(33, 108);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(799, 306);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 439);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnCopyTo);
            this.Controls.Add(this.btnShowPhoneBook);
            this.Controls.Add(this.btnPhoneSearch);
            this.Controls.Add(this.btnAgentSearch);
            this.Controls.Add(this.btnRemovePhone);
            this.Controls.Add(this.btnRemoveAgent);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAgent;
        private System.Windows.Forms.Button btnRemovePhone;
        private System.Windows.Forms.Button btnAgentSearch;
        private System.Windows.Forms.Button btnPhoneSearch;
        private System.Windows.Forms.Button btnShowPhoneBook;
        private System.Windows.Forms.Button btnCopyTo;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}



