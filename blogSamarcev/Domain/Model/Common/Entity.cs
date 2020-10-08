using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogSamarcev.Domain.Model.Common
{
    /// <summary>
    /// Интерфейс модели сущности предметной области
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// Создание экземляра модели сущности предметной области
        /// </summary>
        protected Entity()
        { }

        /// <summary>
        /// Идентификатор сущности
        /// </summary>
        public virtual long Id { get; set; }
    }
}
