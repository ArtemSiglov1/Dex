using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.Vlaueobj
{
    ///<summary>
    /// Базовый абстрактный класс для значимых объектов.
    /// </summary>
    public abstract class BaseValueObj
    {
        /// <summary>
        /// Определяет, равен ли указанный объект текущему объекту.
        /// </summary>
        /// <param name="obj">Объект, который требуется сравнить с текущим объектом.</param>
        /// <returns>True, если указанный объект равен текущему объекту; в противном случае — False.</returns>
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        /// <summary>
        /// Возвращает хэш-код для текущего объекта.
        /// </summary>
        /// <returns>Хэш-код для текущего объекта.</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
