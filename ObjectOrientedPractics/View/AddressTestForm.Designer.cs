
namespace ObjectOrientedPractics.View
{
    /// <summary>
    /// Форма для проверки AddressControl.
    /// </summary>
    partial class AddressTestForm
    {
        /// <summary>
        /// Контейнер компонентов формы.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освобождает ресурсы формы.
        /// </summary>
        /// <param name="disposing">
        /// Признак освобождения ресурсов.
        /// </param>
        protected override void Dispose(bool disposing)
        {
            // Освобождаем компоненты.
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Инициализирует элементы формы.
        /// </summary>
        private void InitializeComponent()
        {
            // Создаём элементы управления.
            addressControl1 =
                new ObjectOrientedPractics.View.Controls.AddressControl();

            LoadAddressButton = new Button();
            CheckAddressButton = new Button();

            SuspendLayout();

            //
            // addressControl1
            //

            // Настраиваем элемент адреса.
            addressControl1.Location = new Point(-2, -2);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(725, 300);
            addressControl1.TabIndex = 0;

            //
            // LoadAddressButton
            //

            // Настраиваем кнопку загрузки адреса.
            LoadAddressButton.Location = new Point(12, 235);
            LoadAddressButton.Name = "LoadAddressButton";
            LoadAddressButton.Size = new Size(94, 29);
            LoadAddressButton.TabIndex = 1;
            LoadAddressButton.Text = "Load Address";
            LoadAddressButton.UseVisualStyleBackColor = true;

            //
            // CheckAddressButton
            //

            // Настраиваем кнопку проверки адреса.
            CheckAddressButton.Location = new Point(124, 235);
            CheckAddressButton.Name = "CheckAddressButton";
            CheckAddressButton.Size = new Size(94, 29);
            CheckAddressButton.TabIndex = 2;
            CheckAddressButton.Text = "Check Address";
            CheckAddressButton.UseVisualStyleBackColor = true;

            //
            // AddressTestForm
            //

            // Настраиваем форму.
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);

            // Добавляем элементы на форму.
            Controls.Add(CheckAddressButton);
            Controls.Add(LoadAddressButton);
            Controls.Add(addressControl1);

            Name = "AddressTestForm";
            Text = "AddressTestForm";

            ResumeLayout(false);
        }

        #endregion

        /// <summary>
        /// Элемент ввода адреса.
        /// </summary>
        private Controls.AddressControl addressControl1;

        /// <summary>
        /// Кнопка загрузки адреса.
        /// </summary>
        private Button LoadAddressButton;

        /// <summary>
        /// Кнопка проверки адреса.
        /// </summary>
        private Button CheckAddressButton;
    }
}
