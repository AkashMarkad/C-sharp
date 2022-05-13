namespace Collection
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
            this.btn_ArrayList = new System.Windows.Forms.Button();
            this.btn_SortedList = new System.Windows.Forms.Button();
            this.btn_HashTable = new System.Windows.Forms.Button();
            this.btn_Stack = new System.Windows.Forms.Button();
            this.btn_Queue = new System.Windows.Forms.Button();
            this.label_Output = new System.Windows.Forms.Label();
            this.txt_Output = new System.Windows.Forms.RichTextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ArrayList
            // 
            this.btn_ArrayList.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ArrayList.Location = new System.Drawing.Point(93, 87);
            this.btn_ArrayList.Name = "btn_ArrayList";
            this.btn_ArrayList.Size = new System.Drawing.Size(152, 51);
            this.btn_ArrayList.TabIndex = 0;
            this.btn_ArrayList.Text = "ArrayList";
            this.btn_ArrayList.UseVisualStyleBackColor = true;
            this.btn_ArrayList.Click += new System.EventHandler(this.btn_ArrayList_Click);
            // 
            // btn_SortedList
            // 
            this.btn_SortedList.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SortedList.Location = new System.Drawing.Point(93, 157);
            this.btn_SortedList.Name = "btn_SortedList";
            this.btn_SortedList.Size = new System.Drawing.Size(152, 41);
            this.btn_SortedList.TabIndex = 1;
            this.btn_SortedList.Text = "SortedList";
            this.btn_SortedList.UseVisualStyleBackColor = true;
            this.btn_SortedList.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_HashTable
            // 
            this.btn_HashTable.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HashTable.Location = new System.Drawing.Point(93, 213);
            this.btn_HashTable.Name = "btn_HashTable";
            this.btn_HashTable.Size = new System.Drawing.Size(152, 41);
            this.btn_HashTable.TabIndex = 2;
            this.btn_HashTable.Text = "HashTable";
            this.btn_HashTable.UseVisualStyleBackColor = true;
            this.btn_HashTable.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Stack
            // 
            this.btn_Stack.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stack.Location = new System.Drawing.Point(93, 269);
            this.btn_Stack.Name = "btn_Stack";
            this.btn_Stack.Size = new System.Drawing.Size(152, 46);
            this.btn_Stack.TabIndex = 3;
            this.btn_Stack.Text = "Stack";
            this.btn_Stack.UseVisualStyleBackColor = true;
            this.btn_Stack.Click += new System.EventHandler(this.btn_Stack_Click);
            // 
            // btn_Queue
            // 
            this.btn_Queue.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Queue.Location = new System.Drawing.Point(93, 332);
            this.btn_Queue.Name = "btn_Queue";
            this.btn_Queue.Size = new System.Drawing.Size(152, 42);
            this.btn_Queue.TabIndex = 4;
            this.btn_Queue.Text = "Queue";
            this.btn_Queue.UseVisualStyleBackColor = true;
            this.btn_Queue.Click += new System.EventHandler(this.btn_Queue_Click);
            // 
            // label_Output
            // 
            this.label_Output.AutoSize = true;
            this.label_Output.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Output.Location = new System.Drawing.Point(480, 65);
            this.label_Output.Name = "label_Output";
            this.label_Output.Size = new System.Drawing.Size(82, 26);
            this.label_Output.TabIndex = 5;
            this.label_Output.Text = "Output";
            // 
            // txt_Output
            // 
            this.txt_Output.Location = new System.Drawing.Point(368, 157);
            this.txt_Output.Name = "txt_Output";
            this.txt_Output.Size = new System.Drawing.Size(357, 217);
            this.txt_Output.TabIndex = 6;
            this.txt_Output.Text = "";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(93, 397);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(152, 42);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 543);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.txt_Output);
            this.Controls.Add(this.label_Output);
            this.Controls.Add(this.btn_Queue);
            this.Controls.Add(this.btn_Stack);
            this.Controls.Add(this.btn_HashTable);
            this.Controls.Add(this.btn_SortedList);
            this.Controls.Add(this.btn_ArrayList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ArrayList;
        private System.Windows.Forms.Button btn_SortedList;
        private System.Windows.Forms.Button btn_HashTable;
        private System.Windows.Forms.Button btn_Stack;
        private System.Windows.Forms.Button btn_Queue;
        private System.Windows.Forms.Label label_Output;
        private System.Windows.Forms.RichTextBox txt_Output;
        private System.Windows.Forms.Button btn_Exit;
    }
}

