﻿using System;
using System.Collections.Generic;
using System.Text;
using ChapooDatabaseDal;
using ChapooDatabaseModel;

namespace ChapooDatabaseLogic
{
    public class TableService
    {
        readonly ChapooDatabaseDal.TableDAO dao = new TableDAO();

        public List<Table> GetAllTables()
        {
            return dao.getAllTables();
        }

        public List<MenuItem> getMenuCard()
        {
            return dao.getMenuCard();
        }
        
        public List<MenuItem> getMenuCardLunch()
        {
            return dao.getMenuCardLunch();
        }
        
        public List<MenuItem> getMenuCardDiner()
        {
            return dao.getMenuCardDiner();
        }
        
        public List<MenuItem> getMenuCardDrankAlchol()
        {
            return dao.getMenuCardDrankAlchol();
        }
        
        public List<MenuItem> getMenuCardDrank()
        {
            return dao.getMenuCardDrank();
        }

        public bool ItemExist(int e)
        {
            if (dao.ItemExist(e) != 0)
                return true;
            else
                return false;
        }

        public void createTableOrder(int tid, int eid)
        {
            dao.createTableOrder(tid, eid);
        }

        public void deleteTableOrder(int tableId, int orderId)
        {
            dao.deleteTableOrder(tableId, orderId);
        }

        public bool CheckIfTableExistAndHasAnOrder(int id)
        {
            if (dao.CheckIfTableExist(id) == 1)
                return true;
            else
                return false;
        }
        
        public bool OrderItemExist(int id, int OrderId)
        {
            if (dao.OrderItemExist(id, OrderId) == 1)
                return true;
            else
                return false;
        }
        public bool ThereIsStockOfTheItem(int MenuItemID)
        {
            if (dao.ThereIsStockOfTheItem(MenuItemID) == 1)
                return true;
            else
                return false;
        }

        public Order getSingleOrder(int TableId)
        {
            return dao.getSingleOrder(TableId);
        }

        public void AddMenuItemToOrder(int e, int b)
        {
            dao.AddMenuItemToOrder(e, b);
        }
        public void updateDecreaseStock(int MenuItemId)
        {
            dao.updateDecreaseStock(MenuItemId);
        }
        
        public void removeMenuItemToOrder(int e)
        {
            dao.RemoveMenuItemToOrder(e);
        }
        
        public void updateTableStatus(int tableId, string status)
        {
            dao.updateTableStatus(tableId, status);
        }

        public List<OrderItem> getMenuItemBelongingTowardsOrder(int e)
        {
            return dao.getMenuItemBelongingTowardsOrder(e);
        }

        public List<OrderItem> getReceerdOrderForTableById(int tableId)
        {
            return dao.getReceerdOrderForTableById(tableId);
        }

        public List<Table> getAllTablesForKitchen()
        {
            return dao.getAllTablesForKitchen();
        }

        public MenuItem findMenuItem(string name)
        {
            return dao.findMenuItem(name);
        }
        public Menu findMenuType(string name)
        {
            return dao.findMenuType(name);
        }
        public int findOrderItem(int menuid, int orderid)
        {
            return dao.findOrderItem(menuid, orderid);
        }
    }
}
