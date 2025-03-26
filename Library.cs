using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Library<T> : IMediaManager<T> where T : Media
    {
        private List<T> _mediaList = new List<T>();

        public void Add(T item)
        {
            if (_mediaList.Any(m => m.Title == item.Title))
            {
                throw new InvalidOperationException($"Элемент с названием '{item.Title}' уже существует.");
            }
            _mediaList.Add(item);
        }

        public bool Remove(string title)
        {
            var item = _mediaList.FirstOrDefault(m => m.Title == title);
            if (item == null)
            {
                throw new KeyNotFoundException($"Элемент с названием '{title}' не найден.");
            }
            return _mediaList.Remove(item);
        }

        public T FindByTitle(string title)
        {
            var item = _mediaList.FirstOrDefault(m => m.Title == title);
            if (item == null)
            {
                throw new KeyNotFoundException($"Элемент с названием '{title}' не найден.");
            }
            return item;
        }

        public List<T> GetAllAvailable()
        {
            return _mediaList.Where(m => m.IsAvailable).ToList();
        }
        public void PrintAll()
        {
            foreach (var media in _mediaList)
            {
                Console.WriteLine($"Название: {media.Title}, Автор: {media.Author}, Год: {media.YearPublished}");
            }
        }

        public void CheckOut(string title)
        {
            var item = FindByTitle(title);
            if (!item.IsAvailable)
            {
                throw new InvalidOperationException($"Элемент с названием '{title}' уже выдан.");
            }
            item.IsAvailable = false;
        }

        public void Return(string title)
        {
            var item = FindByTitle(title);
            if (item.IsAvailable)
            {
                throw new InvalidOperationException($"Элемент с названием '{title}' уже доступен.");
            }
            item.IsAvailable = true;
        }
    }
}
