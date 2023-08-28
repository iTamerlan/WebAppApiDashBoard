﻿using Dashboard.Contracts.Attachment;
using Dashboard.Contracts.Base;

namespace Dashboard.Contracts;

/// <summary>
/// Комментарий.
/// </summary>
public class CommentDto : BaseDto
{
    /// <summary>
    /// Заголовок.
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// Контент (текст/изображения).
    /// </summary>
    //public IReadOnlyCollection<ContentDto> ContentList { get; set; }
    /// <summary>
    /// Автор.
    /// </summary>
    public IReadOnlyCollection<PublicUserDto> Author { get; set; }
}