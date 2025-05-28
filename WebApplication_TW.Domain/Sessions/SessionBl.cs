using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication_TW.BusinessLogic.Core;
using WebApplication_TW.BusinessLogic.Interfaces;
using WebApplication_TW.Domain.Entities.User;

namespace WebApplication_TW.BusinessLogic
{
    public class SessionBl : UserApi, ISession
    {
        public ULoginResp SaveTodoData(UTodoDate data)
        {
            return UserChangeAction(data);
        }

        public ULoginResp UserTodo(TodoMinimal todo, UserMinimal user)
        {
            return UserTodoAction(todo, user);
        }

        public ULoginResp UserRegister(ULoginDate data)
        {
            return UserRegisterAction(data);
        }
        public ULoginResp UserLogin(ULoginDate data)
        {
            return UserLoginAction(data);
        }

        public List<TodoMinimal> GetTodoList(UserMinimal user)
        {
            return RGetTodoList(user);
        }

        public List<UDbTable> GetUserList()
        {
            return RGetUserList();
        }

        public HttpCookie GenCookie(string loginCredential)
        {
            return Cookie(loginCredential);
        }
        public UserMinimal GetUserByCookie(string apiCookieValue)
        {
            return UserCookie(apiCookieValue);
        }



        public List<TodoMinimal> GetAllTodo()
        {
            return RGetAllTodo();
        }

        public TodoMinimal GetTodoById(int id)
        {
            return RGetTodoById(id);
        }

        public void EditTodo(int id, TodoMinimal user)
        {
            REditTodo(id, user);
        }

        public void DeleteTodo(int id)
        {
            RDeleteTodo(id);
        }
    }
}
