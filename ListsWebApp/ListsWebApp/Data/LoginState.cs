using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListsWebApp.Data
{
    public class LoginState
    {
        public bool IsLoggedIn = false;
        public string username { get; set; }
        public int userId = -1;
        public event Action OnChange;

        public void SetLogin(bool login, string userName, int id)
        {
            IsLoggedIn = login;
            username = userName;
            userId = id;
            NotifyStateChanged();
        }

        public void SetLogin(LoginState ls)
        {
            IsLoggedIn = ls.IsLoggedIn;
            username = ls.username;
            userId = ls.userId;
            NotifyStateChanged();
        }

        private void NotifyStateChanged()
        {
            OnChange?.Invoke();
        }

    }
}
