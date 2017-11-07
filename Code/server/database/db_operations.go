/**************************************************************
 * db_operations.go
 *
 * Implements functions for database operations on MySQL database
 *
 * 	                Version History
 *   Author          Type of change          Description
 *   Kanika			 Addition				 Created File

 **************************************************************/

package main

import (
	"database/sql"
	_ "github.com/go-sql-driver/mysql"
)

type Database_Operations struct {
}

func (operation *Database_Operations) get_data(query string, parameters []string) *sql.Rows {
	db1 := Database_Connection{}
	con, _ := db1.get_connection()
	var rows *sql.Rows
	vals := []interface{}{}
	if len(parameters) > 0 {
		for i := 0; i < len(parameters); i++ {
			vals = append(vals, parameters[i])
		}
		stmt, _ := con.Prepare(query)
		rows, _ = stmt.Query(vals...)
		defer stmt.Close()
	} else {
		rows, _ = con.Query(query)
	}
	defer con.Close()
	return rows
}

func (operation *Database_Operations) update_data(query string, parameters string) *sql.Rows {
	db1 := Database_Connection{}
	con, _ := db1.get_connection()
	rows, _ := con.Query(query)
	defer con.Close()
	return rows
}

func (operation *Database_Operations) insert_data(query string, parameters string) *sql.Rows {
	db1 := Database_Connection{}
	con, _ := db1.get_connection()
	rows, _ := con.Query(query)
	defer con.Close()
	return rows
}

func (operation *Database_Operations) delete_data(query string, parameters string) *sql.Rows {
	db1 := Database_Connection{}
	con, _ := db1.get_connection()
	rows, _ := con.Query(query)
	defer con.Close()
	return rows
}
