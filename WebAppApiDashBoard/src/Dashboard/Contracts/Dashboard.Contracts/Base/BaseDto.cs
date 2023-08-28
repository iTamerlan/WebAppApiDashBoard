// добавил visual studio
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Contracts.Base
{
    /// <summary>
    /// Базовый контракт.
    /// </summary>
    public class BaseDto
    {
        /// <summary>
        /// Идентификатор сущности.
        /// </summary>
        public Guid Id { get; set; }
    }
}
