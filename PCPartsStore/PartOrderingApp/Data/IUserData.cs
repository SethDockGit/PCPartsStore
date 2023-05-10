using System;
using System.Collections.Generic;
using System.Text;
using PCPartsStore.Models;

namespace PCPartsStore.Data
{
    public interface IUserData
    {
        public User GetUser(string username);
        public void ReWriteFile();
    }
}
