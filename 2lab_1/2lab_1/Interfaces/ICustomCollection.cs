using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab_1.Interfaces
{
    public interface ICustomCollection<T> : IEnumerable<T>
    {
        // Индексатор коллекции
        T this[int index] { get; set; }

        // Метод, устанавливающий курсор в начало коллекции
        void Reset();

        // Метод, перемещающий курсор на следующий элемент коллекции
        void Next();

        // Метод, возвращающий элемент текущего положения курсора
        T Current();

        // Свойство, возвращающее количество элементов в коллекции
        int Count { get; }

        // Метод, добавляющий объект item в конец коллекции
        void Add(T item);

        // Метод, удаляющий объект item из коллекции
        void Remove(T item);

        // Метод, удаляющий элемент текущего положения курсора
        T RemoveCurrent();
        public bool Any(Func<T, bool> predicate);
    }

}
