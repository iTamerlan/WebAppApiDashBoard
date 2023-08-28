using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Contracts.Attachment
{
    internal class ContentDto
    {
        /// <summary>
        /// Описание.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Изображение.
        /// </summary>
        public IReadOnlyCollection<ImageDto> Image { get; set; }
        /// <summary>
        /// Номер по порядку.
        /// </summary>
        public int Number { get; set; }
    }
}
