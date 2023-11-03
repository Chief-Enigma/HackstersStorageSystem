using MongoDB.Bson.Serialization.Attributes;


namespace core
{
    internal class DB_Packages
    {
    }
    public class Item_package
    {
        [BsonId]
        public Guid Id { get; set; }                            // 69oMiTMzYE2akqnqLVD8pA==
        public int ItemDataBase_ID { get; set; }                //Database ID
        public string Item_Name { get; set; }                   // RedBull
        public string HSS_Number { get; set; }                  // HSS 16834682
        public string Product_Number { get; set; }              //EAN Number from barcode
        public int Quantity { get; set; }                       // 38 Pcs.
        public List<string> Category_Name { get; set; }         // "Drink","Energy",...
        public List<Specification> Specification { get; set; }
        public Supplier Supplier { get; set; }
        public StoragePlace StoragePlace { get; set; }
        public Payload Payload { get; set; }
        public Item_package(int c_ItemDataBase_ID, string c_Item_Name, string c_HSS_Number, string c_Product_Number, int c_Quantity, List<string> c_Category_Name,
            List<Specification> c_Specification, Supplier c_Supplier, StoragePlace c_StoragePlace, Payload c_Payload)
        {
            ItemDataBase_ID = c_ItemDataBase_ID;
            Item_Name = c_Item_Name;
            HSS_Number = c_HSS_Number;
            Product_Number = c_Product_Number;
            Quantity = c_Quantity;
            Category_Name = c_Category_Name;
            Specification = c_Specification;
            Supplier = c_Supplier;
            StoragePlace = c_StoragePlace;
            Payload = c_Payload;
        }
    }

    public class Specification
    {
        public string Specification_Name { get; set; }          // Liquid amount        Flavor
        public string Specification_Value { get; set; }         // 250                  Feige-Apfel
        public string Specification_Unite { get; set; }         // ml                   -
        public Specification(string c_Specification_Name, string c_Specification_Value, string c_Specification_Unite)
        {
            Specification_Name = c_Specification_Name;
            Specification_Value = c_Specification_Value;
            Specification_Unite = c_Specification_Unite;
        }
    }

    public class Supplier
    {
        public string Supplier_Name { get; set; }               // Coop
        public string Supplier_Number { get; set; }             // 7640164520315
        public string Supplier_Price { get; set; }              // 11.96 CHF
        public Supplier(string c_Supplier_Name, string c_Supplier_Number, string c_Supplier_Price)
        {
            Supplier_Name = c_Supplier_Name;
            Supplier_Number = c_Supplier_Number;
            Supplier_Price = c_Supplier_Price;
        }
    }

    public class StoragePlace
    {
        public string Storage_Room { get; set; }                // Room xyz
        public string Storage_Shelf { get; set; }               // A,B,C,...
        public int Storage_Level { get; set; }                  // 1,2,3,...
        public int Storage_Box { get; set; }                    // Box 42
        public StoragePlace(string c_Storage_Room, string c_Storage_Shelf, int c_Storage_Level, int c_Storage_Box)
        {
            Storage_Room = c_Storage_Room;
            Storage_Shelf = c_Storage_Shelf;
            Storage_Level = c_Storage_Level;
            Storage_Box = c_Storage_Box;
        }
    }

    public class Payload
    {
        public string Payload_PicturePath { get; set; }         // R:Shelf/Server/HSS/Pictures/"insertItemID"
        public string Payload_LogPath { get; set; }             // R:Shelf/Server/HSS/Logs/"insertItemID"
        public Payload(string c_Payload_PicturePath, string c_Payload_LogPath)
        {
            Payload_PicturePath = c_Payload_PicturePath;
            Payload_LogPath = c_Payload_LogPath;
        }
    }


    //HSS Data Bson Document

    public class DataBaseConfigs
    {
        public Guid Id { get; set; }
        public List<SupplierData> SupplierData { get; set; }
        public List<CategoryData> CategoryData { get; set; }
        public DataBaseConfigs(List<SupplierData> c_SupplierData, List<CategoryData> c_CategoryData) {
            SupplierData = c_SupplierData;
            CategoryData = c_CategoryData;
        
        }
    }

    public class SupplierData
    {
        public int ItemDataBase_ID { get; set; }                 //Database ID
        public string SupplierData_Name { get; set; }           // Coop
        public string SupplierData_Link { get; set; }           // "https://www.coop.ch/de/search/?text="
        public SupplierData(string c_SupplierData_Name, string c_SupplierData_Link)
        {
            SupplierData_Name = c_SupplierData_Name;
            SupplierData_Link = c_SupplierData_Link;
        }
    }

    public class CategoryData
    {
        public int ItemDataBase_ID { get; set; }                 //Database ID
        public List<string> CategoryData_Name { get; set; }     // "Drink","Energy",...
        public CategoryData(List<string> c_CategoryData_Name)
        {
            CategoryData_Name = c_CategoryData_Name;
        }
    }



    //User Data 

    public class UserData
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }                    //Username and myabe something with id
        public string User_FirstName { get; set; }              //Firstname 
        public string User_Lastname { get; set; }               //Lastname
        public string User_Email { get; set; }                  //Email adress
        public string User_Password { get; set; }               //Password from user
        public List<UserDBAccess> DataBaseAccess { get; set; }  //List of connected DB's
        public UserData(string c_UserName, string c_User_FirstName, string c_User_LastName, string c_User_Email, string c_User_Password, List<UserDBAccess> c_DataBaseAccess)
        {
            UserName = c_UserName;
            User_FirstName = c_User_FirstName;
            User_Lastname = c_User_LastName;
            User_Email = c_User_Email;
            User_Password = c_User_Password;
            DataBaseAccess = c_DataBaseAccess;
        }

    }

    public class UserDBAccess
    {
        public int UserDataBase_ID { get; set; }                //DataBase ID for searching
        public string UserDataBase_Name { get; set; }           //DataBase Name for display
        public string UserDataBase_Role { get; set; }           //Users Role from DataBase Owner, Admin, etc
        public UserDBAccess(int c_UserDataBase_ID, string c_UserDataBase_Name, string c_UserDataBase_Role)
        {
            UserDataBase_ID = c_UserDataBase_ID;
            UserDataBase_Name = c_UserDataBase_Name;
            UserDataBase_Role = c_UserDataBase_Role;
        }
    }

    //Search Packages

    public class SearchRequest
    {
        public string DataBase_Id { get; set; }
        public string SearchBar {  get; set; }
        public List<string> Categorys { get; set; }
        public SearchRequest(string c_DataBase_Id, string c_SearchBar, List<string> c_Categorys)
        {
            DataBase_Id = c_DataBase_Id;
            SearchBar = c_SearchBar;
            Categorys = c_Categorys;
        }

    }
    
    public class SearchResponse
    {
        public string Item_Name { get; set; }                   // RedBull
        public string HSS_Number { get; set; }                  // HSS 16834682
        public int Quantity { get; set; }                       // 38 Pcs.
        public SearchResponse(string c_item_name, string c_hss_number, int c_quantity)
        {
            Item_Name = c_item_name;
            HSS_Number = c_hss_number;
            Quantity = c_quantity;
        }
    }

}
