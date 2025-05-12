namespace YouKassaAssistant.UI.Domain;

/// <summary>
/// Модель для обращения
/// </summary>
public class Tikets
{
    /// <summary>
    /// Ключ обращения
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Описание обращения
    /// </summary>
    public string Theme { get; set; }

    /// <summary>
    /// Описание обращения
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Фото обращения
    /// </summary>
    public byte[]? ImageBytes { get; set; }

    /// <summary>
    /// Статус обращения
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// Оценка обращения
    /// </summary>
    public float Score { get; set; }

    /// <summary>
    /// Нужно ли просмотреть обращение
    /// </summary>
    public bool IsVisible { get; set; }

    /// <summary>
    /// Срочное ли обращение
    /// </summary>
    public bool IsFire { get; set; }

    /// <summary>
    /// Цена обращения
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Дата обращения обращения
    /// </summary>
    public DateTime DateCreate { get; set; }

    /// <summary>
    /// Ключ сотрудника
    /// </summary>
    public int WorkerId { get; set; }

    /// <summary>
    /// Имя сотрудника
    /// </summary>
    public string WorkerFullName { get; set; }
}
