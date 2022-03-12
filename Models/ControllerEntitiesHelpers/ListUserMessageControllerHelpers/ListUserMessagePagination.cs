﻿using System;

namespace OpenSourceEnity.Models.ControllerEntitiesHelpers.ListUserMessageControllerHelpers
{
    //<summary>
    //Класс реализующий пагинацию на форме отправки сообщений пользователям
    //</summary>
    public class ListUserMessagePagination
    {
        //<summary>
        //Текущая страница
        //</summary>
        public int CurrentPage { get; set; }

        //<summary>
        //Количество страниц
        //</summary>
        public int CountPage { get; set; }

        //<summary>
        //Всего страниц
        //</summary>
        public int TotalPage { get; set; }

        //<summary>
        //Всего элементов
        //</summary>
        public int TotalItems { get; set; }

        //<summary>
        //Свойство получения информаци о предыдущей страницы
        //</summary>
        public bool BeforePage
        {
            get
            {
                return CurrentPage > 0;
            }
        }

        //<summary>
        //Свойство получения информаци о следующий страницы
        //</summary>
        public bool AfterPage
        {
            get
            {
                return CurrentPage < TotalPage;
            }
        }

        //<summary>
        //Конструктор предоставляющий инициализацию параметров: 
        ///<param name="CurrentPage">Текущая страница.</param>
        ///<param name="CountPage">Всего страниц.</param>
        ///<param name="TotalItems">Всего элементов на страницы.</param>
        //</summary>
        public ListUserMessagePagination(int CurrentPage, int CountPage, int TotalItems)
        {
            this.CurrentPage = CurrentPage;
            this.CountPage = CountPage;
            this.TotalItems = TotalItems;

            TotalPage = (int)Math.Ceiling((double)CountPage / TotalItems);
        }
    }
}
