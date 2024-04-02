using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Domen.Entities
{
    /// <summary>
    ///  Базовый класс для всех сущностей
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// свойство айди
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// метод для сравнения 
        /// </summary>
        /// <param name="obj">сущность</param>
        /// <returns>является ли объект obj экземпляром класса BaseEntity и, если да, сравнивает их Id</returns>
        public override bool Equals(object? obj)
        {
            return obj is BaseEntity entity &&
          Id == entity.Id;
        }
        /// <summary>
        /// Возвращает хэш-код текущего объекта.
        /// </summary>
        /// <returns>
        /// Хэш-код текущего объекта.
        /// </returns>
        /// <exception cref="NotImplementedException">Всегда бросает исключение, так как метод не реализован.</exception>
        public override int GetHashCode()
        {
            
            throw new NotImplementedException();
        }

    }
}
