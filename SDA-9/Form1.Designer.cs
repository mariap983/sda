namespace SDA_9
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
            this.btnCreateGraph1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnCreateGraph2 = new System.Windows.Forms.Button();
            this.btnCreateGraph3 = new System.Windows.Forms.Button();
            this.btnDijkstra = new System.Windows.Forms.Button();
            this.btnClearGraph = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateGraph1
            // 
            this.btnCreateGraph1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateGraph1.Location = new System.Drawing.Point(637, 60);
            this.btnCreateGraph1.Name = "btnCreateGraph1";
            this.btnCreateGraph1.Size = new System.Drawing.Size(134, 26);
            this.btnCreateGraph1.TabIndex = 0;
            this.btnCreateGraph1.Text = "Създай граф 1";
            this.btnCreateGraph1.UseVisualStyleBackColor = true;
            this.btnCreateGraph1.Click += new System.EventHandler(this.btnCreateGraph1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Матрица на съседство";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 64);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(592, 374);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // btnCreateGraph2
            // 
            this.btnCreateGraph2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateGraph2.Location = new System.Drawing.Point(637, 92);
            this.btnCreateGraph2.Name = "btnCreateGraph2";
            this.btnCreateGraph2.Size = new System.Drawing.Size(134, 26);
            this.btnCreateGraph2.TabIndex = 3;
            this.btnCreateGraph2.Text = "Създай граф 2";
            this.btnCreateGraph2.UseVisualStyleBackColor = true;
            this.btnCreateGraph2.Click += new System.EventHandler(this.btnCreateGraph2_Click);
            // 
            // btnCreateGraph3
            // 
            this.btnCreateGraph3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateGraph3.Location = new System.Drawing.Point(637, 124);
            this.btnCreateGraph3.Name = "btnCreateGraph3";
            this.btnCreateGraph3.Size = new System.Drawing.Size(134, 26);
            this.btnCreateGraph3.TabIndex = 4;
            this.btnCreateGraph3.Text = "Създай граф 3";
            this.btnCreateGraph3.UseVisualStyleBackColor = true;
            this.btnCreateGraph3.Click += new System.EventHandler(this.btnCreateGraph3_Click);
            // 
            // btnDijkstra
            // 
            this.btnDijkstra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDijkstra.Location = new System.Drawing.Point(637, 156);
            this.btnDijkstra.Name = "btnDijkstra";
            this.btnDijkstra.Size = new System.Drawing.Size(134, 26);
            this.btnDijkstra.TabIndex = 5;
            this.btnDijkstra.Text = "Дейкстра";
            this.btnDijkstra.UseVisualStyleBackColor = true;
            this.btnDijkstra.Click += new System.EventHandler(this.btnDijkstra_Click);
            // 
            // btnClearGraph
            // 
            this.btnClearGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearGraph.Location = new System.Drawing.Point(637, 188);
            this.btnClearGraph.Name = "btnClearGraph";
            this.btnClearGraph.Size = new System.Drawing.Size(134, 26);
            this.btnClearGraph.TabIndex = 6;
            this.btnClearGraph.Text = "Изтрий графа";
            this.btnClearGraph.UseVisualStyleBackColor = true;
            this.btnClearGraph.Click += new System.EventHandler(this.btnClearGraph_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(637, 412);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 26);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Затвори";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClearGraph);
            this.Controls.Add(this.btnDijkstra);
            this.Controls.Add(this.btnCreateGraph3);
            this.Controls.Add(this.btnCreateGraph2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateGraph1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateGraph1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnCreateGraph2;
        private System.Windows.Forms.Button btnCreateGraph3;
        private System.Windows.Forms.Button btnDijkstra;
        private System.Windows.Forms.Button btnClearGraph;
        private System.Windows.Forms.Button btnClose;
    }
}

