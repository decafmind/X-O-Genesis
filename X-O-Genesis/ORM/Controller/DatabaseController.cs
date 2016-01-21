using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Entity;
using System.Data;

namespace PetvetPOS_Inventory_System
{
     // TODO: ASAP
    /* Acts like masterController but it manages all 
     * controller for Database.
     * This class also hold the reference of MySqlDB
     */
    public class DatabaseController
    {
        public event EventHandler<EntityArgs> InsertEntity;
        public event EventHandler<EntityArgs> UpdateEntity;
        public event EventHandler<EntityArgs> DeleteEntity;

        /* Properties */
        public MySqlDB mySqlDB { get; private set; }
        public EmployeeMapper employeeMapper { get; private set; }
        public MasterController masterController { get; set; }

        public UserMapper userMapper { get; set; }
        public LoginTrailMapper loginTrailMapper { get; set; }
        public MySqlTransaction Transaction { get; set; }
        public MySqlCommand Command{ get; set; }

        public ProductMapper productMapper { get; set; }
        public InventoryMapper inventoryMapper { get; set; }
        public ProductInventory productInventory { get; set; }
        public InvoiceMapper invoiceMapper { get; set; }

        public ProductInvoiceMapper productInvoiceMapper { get; set; }
        public Receipt receipt { get; set; }
        public PurchasedProductMapper purchasedProductMapper { get; set; }
        public TodaySalesMapper todaySalesMapper { get; set; }

        public DailySalesReportMapper dailySalesReportMapper { get; set; }
        public WeeklySalesReport weeklySalesReportMapper { get; set; }
        public MonthlySaleReportMapper monthlySalesReportMapper { get; set; }
        public CategoryMapper categoryMapper { get; set; }

        public MedicalMapper medicalMapper { get; set; }
        public GroomingView groomingViewMapper { get; set; }

        public ServiceRenderedMapper serviceRenderedMapper { get; set; }
        public AuditTrailMapper auditTrailMapper { get; set; }
        public AuditTrailView auditTrailView { get; set; }

        public ProductTransactionView productTransactionView { get; set; }
        public LoginTrailViewMapper loginTrailViewMapper { get; set; }
        public MedicalTransactionMapper medicalTransactionMapper { get; set; }

        public ProductReturnViewMapper productReturnViewMapper { get; set; }
        public FallbackMapper fallbackMapper { get; set; }
        public SupplierMapper supplierMapper { get; set; }
        public ProductInspectionMapper productInspectionMapper { get; set; }

        public DatabaseController(MasterController masterController)
        {
            this.mySqlDB = new MySqlDB();
            this.masterController = masterController;
            this.employeeMapper = new EmployeeMapper(mySqlDB);
            this.supplierMapper = new SupplierMapper(mySqlDB);

            this.userMapper = new UserMapper(mySqlDB);
            this.loginTrailMapper = new LoginTrailMapper(mySqlDB);
            this.productMapper = new ProductMapper(mySqlDB);
            this.inventoryMapper = new InventoryMapper(mySqlDB);

            this.productInventory = new ProductInventory(mySqlDB);
            this.invoiceMapper = new InvoiceMapper(mySqlDB);
            this.productInvoiceMapper = new ProductInvoiceMapper(mySqlDB);
            this.receipt = new Receipt(mySqlDB);

            this.purchasedProductMapper = new PurchasedProductMapper(mySqlDB);
            this.todaySalesMapper = new TodaySalesMapper(mySqlDB);
            this.dailySalesReportMapper = new DailySalesReportMapper(mySqlDB);
            this.weeklySalesReportMapper = new WeeklySalesReport(mySqlDB);

            this.monthlySalesReportMapper = new MonthlySaleReportMapper(mySqlDB);
            this.categoryMapper = new CategoryMapper(mySqlDB);
         
            this.serviceRenderedMapper = new ServiceRenderedMapper(mySqlDB);

            this.auditTrailMapper = new AuditTrailMapper(mySqlDB);
            this.auditTrailView = new AuditTrailView(mySqlDB);
            this.productTransactionView = new ProductTransactionView(mySqlDB);
            this.loginTrailViewMapper = new LoginTrailViewMapper(mySqlDB);

           
            this.medicalTransactionMapper = new MedicalTransactionMapper(mySqlDB);
            this.productReturnViewMapper = new ProductReturnViewMapper(mySqlDB);

            this.fallbackMapper = new FallbackMapper(mySqlDB);
            this.productInspectionMapper = new ProductInspectionMapper(mySqlDB);

            // Events hooking
            this.masterController.EmployeeLogin += masterController_EmployeeLogin;
            this.masterController.EmployeeLogout += masterController_EmployeeLogout;
        }

        void masterController_EmployeeLogout(object sender, EventArgs e)
        {
            loginTrailMapper.insertTimeout(masterController.LoginEmployee);
            userMapper.logout(masterController.LoginEmployee.User_id);
        }

        void masterController_EmployeeLogin(object sender, EmployeeArgs e)
        {
            try
            {
                System.ComponentModel.BackgroundWorker worker = new System.ComponentModel.BackgroundWorker();
                worker.DoWork += worker_DoWork;
                worker.RunWorkerAsync(e.employee);
            }
            catch (InvalidOperationException iex)
            {
                ErrorLog.Log(iex);
            }
            catch (Exception ex)
            {
                ErrorLog.Log(ex);
            }
            
        }

        public bool consumeProductInvoice(ProductInvoice productInvoice)
        {
            return productInvoiceMapper.consumeProductInvoice(productInvoice);
        }

        void worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Employee employee = e.Argument as Employee;
            loginTrailMapper.insertTimeIn(employee);
            login(employee.User_id);
        }

        public bool insertAuditTrail(string action)
        {
            return auditTrailMapper.insertAuditTrail(masterController.LoginEmployee, action, DateTime.Now);
        }

        public bool pullInventory(Inventory inventory)
        {
            return inventoryMapper.pullInventory(inventory);
        }

        public bool login(string user_id)
        {
            return userMapper.login(user_id);
        }

        public bool changePass(string id, string newPass)
        {
            return userMapper.changePass(id, newPass);
        }

        public bool checkUsername(string userName)
        {
            return userMapper.checkUsername(userName);
        }
        public bool isAlreadyLogin(User user)
        {
            return userMapper.isAlreadyLogin(user);
        }

        public bool getSQAnswer(string userName, string sqans)
        {
            return userMapper.getSQAnswer(userName, sqans);
        }
        /* This method will return an instance of User if 
         * user credentials exists in the database
         */
        public User authenticateUser(string user_id, string password)
        {
            return userMapper.validate(user_id, password);
        }

        public void checkProductCriticalLevel(Product product)
        {
            productInventory.checkProductCriticalLevel(product, masterController);
        }

        public bool updateTotalPrice(string transaction_id, decimal new_total_price)
        {
            return receipt.updateTotalPrice(transaction_id, new_total_price);
        }
      
        public bool updateInventory(int qty, string barcode)
        {
            return inventoryMapper.updateInventory(qty, barcode);
        }
        public Employee getEmployeeFromUser(User user)
        {
            return employeeMapper.getEmployeeFromUserId(user);
        }

        public User getUserFromId(string id)
        {
            return userMapper.getUserFromId(id);
        }

        public DataTable getLoginTrail(DataTable dt)
        {
            return loginTrailMapper.getLoginTrailTable(dt);
        }

        
        public DataTable getDailySalesReport(DataTable dt)
        {
            return dailySalesReportMapper.loadTable(dt);
        }

        public bool createCategory(string category)
        {
            return categoryMapper.createNewCategory(category);
        }

        public DataTable filterDailySalesReport(DataTable dt, DateTime from, DateTime to)
        {
            string[] extractFrom = MyExtension.MySqlToCSharp.convertDateTime(from).Split(' ');
            string[] extractTo = MyExtension.MySqlToCSharp.convertDateTime(to).Split(' ');

            string condition = String.Format("date BETWEEN '{0}' AND '{1}'", extractFrom[0], extractTo[0]);
            return dailySalesReportMapper.loadTable(dt, condition);
        }

        public DataTable getProductTransactionFromTransactionID(string transction_id)
        {
            string condition = string.Format("transaction_id = {0} GROUP BY description HAVING SUM(qty_sold) <> 0", transction_id);
            return productTransactionView.loadTable(new DataTable(), condition);
        }

        public List<string> getListOfCategory()
        {
            return categoryMapper.getListOfCategory();
        }

        public List<string> getListOfSquery()
        {
            return fallbackMapper.getListOfSquery();
        }
 
        public DataTable loadAuditTrail(DataTable dt){
            return auditTrailView.loadTable(dt);
        }

        public DataTable filterWeeklySalesReport(DataTable dt, DateTime from, DateTime to)
        {
            string[] extractFrom = MyExtension.MySqlToCSharp.convertDateTime(from).Split(' ');
            string[] extractTo = MyExtension.MySqlToCSharp.convertDateTime(to).Split(' ');

            string condition = String.Format("week BETWEEN Week('{0}') AND Week('{1}')", extractFrom[0], extractTo[0]);
            return weeklySalesReportMapper.loadTable(dt, condition);
        }

        public DataTable getWeeklySalesReport(DataTable dt)
        {
            return weeklySalesReportMapper.loadTable(dt);
        }

        public int getSqueryFromID(string id)
        {
            return userMapper.getSqueryIndexFromID(id);
        }

        public DataTable getMonthlySalesReport(DataTable dt)
        {
            return monthlySalesReportMapper.loadTable(dt);
        }

        public DataTable filterMonthlySalesReport(DataTable dt, DateTime from, DateTime to)
        {
            string[] extractFrom = MyExtension.MySqlToCSharp.convertDateTime(from).Split(' ');
            string[] extractTo = MyExtension.MySqlToCSharp.convertDateTime(to).Split(' ');

            string condition = String.Format("Month_index BETWEEN MONTH('{0}') AND MONTH('{1}') "
             + " AND Year BETWEEN YEAR('{0}') AND YEAR('{1}')" , extractFrom[0], extractTo[0]);
            return monthlySalesReportMapper.loadTable(dt, condition);
        }

        public DataTable filterLoginTrail(DataTable dt, DateTime date)
        {            
            string condition = string.Format("datetime_in BETWEEN '{0}' AND DATE_ADD('{0}', INTERVAL 1 DAY)",
                MyExtension.MySqlToCSharp.convertDate(date));
            return loginTrailViewMapper.loadTable(dt, condition);
        }

        public DataTable filterLoginTrailUserAndDate(DataTable dt, string user, DateTime date)
        {
            string condition = string.Format("user_id = '{0}' AND datetime_in BETWEEN '{1}' AND DATE_ADD('{1}', INTERVAL 1 DAY) ORDER BY datetime_in DESC",
                user, MyExtension.MySqlToCSharp.convertDate(date));
            return loginTrailMapper.loadTable(dt, condition);
        }

        public DataTable filterAuditTrail(DataTable dt, DateTime date)
        {
            string condition = string.Format("date BETWEEN '{0}' AND DATE_ADD('{0}', INTERVAL 1 DAY) ORDER BY time DESC", MyExtension.MySqlToCSharp.convertDate(date));
            return auditTrailView.loadTable(dt, condition);
        }


        public DataTable filterAuditTrailUserAndDate(DataTable dt, string user, DateTime date)
        {
            string condition = string.Format("user_id = '{0}' AND date BETWEEN '{1}' AND DATE_ADD('{1}', INTERVAL 1 DAY) ORDER BY time DESC",
                user, MyExtension.MySqlToCSharp.convertDate(date));
            return auditTrailView.loadTable(dt, condition);
        }

        public DataTable filterServiceRendered(DataTable dt, string token)
        {
            string condition = String.Format(
                " name LIKE '%{0}%'", token
            );

            return serviceRenderedMapper.loadTable(dt, condition);
        }


        public DataTable getBasicProductInfoFromBarcode(DataTable dt, string barcode)
        {
            string condition = String.Format(" item_code = '{0}'", barcode);
            return productInspectionMapper.loadTable(dt, condition);
        }


        public DataTable getCriticalLevelProducts(DataTable dt)
        {
            return productInventory.getCriticalLevelProducts(dt);
        }

        public DataTable getBestSellers(DataTable dt)
        {
            return purchasedProductMapper.getBestSellers(dt);
        }

        public DataTable getLoginTrail(DataTable dt, string userid)
        {
            string condition = String.Format(" id = '{0}'", userid);
            return loginTrailMapper.loadTable(dt, condition);
        }

        public void createUser(User user)
        {
            userMapper.createUser(user);
        }

        public bool removeUser(User user)
        {
            if (userMapper.inactivateUser(user)){
                EntityArgs e = new EntityArgs(user);
                OnDeleteEntity(e);
                return true;
            }
            return false;
        }
        public string createEmployee(Employee employee)
        {
            return employeeMapper.createEmployee(employee);
        }

        public void updateEmployee(Employee oldE, Employee newE)
        {
            if (employeeMapper.updateEmployee(oldE, newE))
            {
                EntityArgs e = new EntityArgs(newE);
                OnUpdateEntity(e);
            }
        }

        public bool updateProduct(Product origP, Product newP)
        {
            if (productMapper.updateProduct(origP, newP)){
                OnUpdateEntity(new EntityArgs(newP));
                return true;
            }
            return false;
        }

   
        public bool insertProductInsideInventory(Inventory inventory, Product product){
            string insertInventory = inventoryMapper.createInventory(inventory);
            string insertProduct = productMapper.createProduct(product);
            if(createTransaction(insertProduct, insertInventory)){
                OnInsertEntity(new EntityArgs(inventory));
                OnInsertEntity(new EntityArgs(product));
                return true;
            }
            return false;
        }

   
        public bool insertInventory(Inventory inventory)
        {
            if (inventoryMapper.insertInventory(inventory)){
                OnInsertEntity(new EntityArgs(inventory));
                return true;
            }
            return false;
        }

        public DataTable loadMedical(DataTable dt)
        {
            return medicalMapper.loadTable(dt);
        }

        public DataTable readInventory(DataTable dt)
        {
            return productInventory.loadTable(dt);
        }

        public DataTable filterInventory(DataTable dt, string token)
        {
            string condition = String.Format(
                " Name LIKE '%{0}%' OR Barcode LIKE '%{0}%' " +
                " OR Category LIKE '%{0}%' OR Supplier LIKE '%{0}%'", token
                );

            return productInventory.loadTable(dt, condition);
        }


        public DataTable filterPurchasedProduct(DataTable dt, string token)
        {
             string condition = String.Format(
                " Name LIKE '%{0}%' OR Barcode LIKE '%{0}%' " +
                " OR Category LIKE '%{0}%' OR Company LIKE '%{0}%' ", token
                );
             return purchasedProductMapper.loadTable(dt, condition);
        }

        public DataTable filterGrooming(DataTable dt, string token)
        {
            string condition = String.Format(
                " grooming_name LIKE '%{0}%' OR petsize LIKE '%{0}%' ", token
               );

            return groomingViewMapper.loadTable(dt, condition);
        }

        public DataTable filterMedical(DataTable dt, string token)
        {
            string condition = String.Format(
             " medical_name LIKE '%{0}%'", token
            );

            return medicalMapper.loadTable(dt, condition);
        }
        public DataTable readPurchasedProduct(DataTable dt)
        {
            return purchasedProductMapper.loadTable(dt, "quantity > 0");
        }

        public int getTransactionId(Invoice transaction)
        {
            return invoiceMapper.getTransactionId(transaction);
        }

        public void insertTransaction(Invoice transaction)
        {
            // This method insert a new row into transaction_tbl
            if (invoiceMapper.insertTransaction(transaction)){
                OnInsertEntity(new EntityArgs(transaction));
            }
        }

        public bool insertReceipt(Invoice transaction, Decimal totalPrice, Decimal cashTender, string name, string address = "N/A")
        {
            return receipt.insertReceipt(transaction, totalPrice, cashTender, name, address);
        }

        public bool insertProductInvoice(ProductInvoice productInvoice)
        {
            return productInvoiceMapper.insertProductInvoice(productInvoice);
        }

        public int getCurrentStockCountFromBarCode(Product product)
        {
            int quantity = (int)productInventory.getStockQuantity(product);
            return quantity;
        }

        public Product getProductFromBarcode(string barcode)
        {
            return productMapper.getProductFromBarcode(barcode);
        }

        
        public Product getProductThroughName(string name)
        {
            return productMapper.getProductFromName(name);   
        }

        public DataTable readEmployeeTable(DataTable dataTable)
        {
            return employeeMapper.loadTable(dataTable);
        }

        public void createUserEmployee(User user, Employee employee)
        {
            string insertUser = userMapper.createUser(user);
            string insertEmployee = employeeMapper.createEmployee(employee);
            if (createTransaction(insertUser, insertEmployee)){
                EntityArgs e = new EntityArgs(employee);
                OnInsertEntity(e);
            }
            user.Dispose();
        }

        public TodaySales getTodaySales()
        {
            return new TodaySales(todaySalesMapper.getSales());
        }

        public bool createTransaction(params string[] args)
        {
            bool success = false;
            mySqlDB.open();
            Transaction = mySqlDB.Connection.BeginTransaction();
            Command = mySqlDB.Connection.CreateCommand();

            Command.Connection = mySqlDB.Connection;
            Command.Transaction = Transaction;
            
            try
            {
                int n = args.Length;
                for (int i = 0; i < n; i++)
                {
                    Command.CommandText = @args[i];
                    if (args[i].Contains("INSERT") || args[i].Contains("UPDATE") || args[i].Contains("DELETE"))
                        Command.ExecuteNonQuery();
                }
                Transaction.Commit();
                success = true;
            }
            catch (MySqlException x)
            {
                System.Windows.Forms.MessageBox.Show(x.Message);
                try
                {
                    Transaction.Rollback();
                }
                catch (MySqlException ex)
                {
                    System.Windows.Forms.MessageBox.Show("An exception of type " + ex.GetType() +
                        " was encounter while inserting the data.");
                }
                success = false;
            }
            finally
            {
                mySqlDB.close();
                mySqlDB.dispose();
            }
            return success;
        }

        public List<string> getListOfAllUsernames()
        {
            return userMapper.getListOfAllUsername();
        }

        public List<string> getListOfActiveUsernames()
        {
            return userMapper.getListOfActiveUsername();
        }

        /* Events trigger */
        private void OnInsertEntity(EntityArgs e)
        {
            EventHandler<EntityArgs> onInsertEntity = InsertEntity;
            if (onInsertEntity != null)
                onInsertEntity(this, e);
        }

        private void OnUpdateEntity(EntityArgs e)
        {
            EventHandler<EntityArgs> onUpdateEntity = UpdateEntity;
            if (onUpdateEntity != null)
                onUpdateEntity(this, e);
        }

        private void OnDeleteEntity(EntityArgs e)
        {
            EventHandler<EntityArgs> onDeleteEntity = DeleteEntity;
            if (onDeleteEntity != null)
                onDeleteEntity(this, e);
        }

        public List<String> getListOfProduct(Invoice invoice)
        {
            return productInvoiceMapper.getListOfProductOnInvoice(invoice);
        }

        public List<ProductInvoice> getListOfProductInvoice(Invoice invoice)
        {
            return productInvoiceMapper.getListOfProductInvoice(invoice);
        }

        public bool checkIfAlreadyConsumed(ProductInvoice productInvoice)
        {
            return productInvoiceMapper.checkIfAlreadyConsumed(productInvoice);
        }
    }
}

