using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace CarritoComprasSupermarket.Conexiones
{
    public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://carritocompras-7fb63-default-rtdb.firebaseio.com/");

    }
}
