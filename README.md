# Proga
GUI для управления манипулятором с присоской

using System;
using System.IO;
using System.Windows.Forms;

public partial class Form1 : Form
{
    private RichTextBox logBox; // Поле для RichTextBox

    public Form1()
    {
        InitializeComponent();

        // Инициализация RichTextBox
        logBox = new RichTextBox
        {
            Dock = DockStyle.Bottom, // Размещаем внизу формы
            ReadOnly = true,
            WordWrap = false,
            ScrollBars = RichTextBoxScrollBars.Vertical,
            Height = 200 // Высота области для логов
        };
        this.Controls.Add(logBox);

        // Кнопка "Сохранить логи"
        Button btnSaveLogs = new Button
        {
            Text = "Сохранить логи",
            Dock = DockStyle.Top,
            Height = 30
        };
        btnSaveLogs.Click += BtnSaveLogs_Click; // Привязываем обработчик события
        this.Controls.Add(btnSaveLogs);

        // Логирование старта программы
        LogMessage("Программа запущена.");
    }

    // Метод для записи логов
    private void LogMessage(string message)
    {
        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        string logMessage = $"[{timestamp}] {message}";

        if (logBox.InvokeRequired)
        {
            logBox.Invoke(new Action<string>(LogMessage), message);
        }
        else
        {
            logBox.AppendText(logMessage + Environment.NewLine);
            logBox.ScrollToCaret(); // Прокрутка до последней строки
        }
    }

    // Обработчик нажатия кнопки "Сохранить логи"
    private void BtnSaveLogs_Click(object sender, EventArgs e)
    {
        try
        {
            // Получаем путь к рабочему столу
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Создаем имя файла с текущей датой
            string fileName = Path.Combine(desktopPath, $"Logs_{DateTime.Now:yyyyMMdd_HHmmss}.txt");

            // Сохраняем текст из RichTextBox в файл
            File.WriteAllText(fileName, logBox.Text);

            // Уведомляем пользователя
            MessageBox.Show($"Логи успешно сохранены в файл:\n{fileName}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception error)
        {
            MessageBox.Show($"Ошибка при сохранении логов: {error.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
