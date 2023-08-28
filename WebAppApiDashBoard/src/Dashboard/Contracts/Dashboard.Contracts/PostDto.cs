using Dashboard.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Contracts
{
    /// <summary>
    /// Объявление.
    /// </summary>
    public class PostDto : BaseDto
    {
        /// <summary>
        /// Заголовок.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Заголовок.
        /// </summary>
        public string User { get; set; }
        /// <summary>
        /// Дата создания.
        /// </summary>
        public string CreateDate { get; set; }
        /// <summary>
        /// Статус (черновик, опубликовано).
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Название категории.
        /// </summary>
        public string CategoryName { get; set; }
        //public string[] Tags { get; set; }
        //public string[] Content { get; set; }
        //public int Rating { get; set; }
        //public decimal Price { get; set; }

    }
}
