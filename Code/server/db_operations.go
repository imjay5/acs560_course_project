/**************************************************************
 * db_operations.go
 *
 * Implements functions for database operations on MySQL database
 *
 * 	                Version History
 *   Author          Type of change          Description
 *   Kanika			 Addition				 Created File
 *   Kanika			 Modification			 Modified signatures of get_data and update_data to support all datatypes
 **************************************************************/

package main

import (
	"database/sql"
	_ "github.com/go-sql-driver/mysql"
	"log"
)

type Database_Operations struct {
}

func (operation *Database_Operations) get_data(query string, parameters []interface{}) (bool, *sql.Rows) {
	db1 := Database_Connection{}
	con, _ := db1.get_connection()
	var rows *sql.Rows
	var err error
	vals := []interface{}{}
	if len(parameters) > 0 {
		for i := 0; i < len(parameters); i++ {
			vals = append(vals, parameters[i])
		}
		stmt, preperr := con.Prepare(query)
		if preperr != nil {
			log.Fatal("Error while preparing select query:: ", preperr)
			return false, rows
		}
		rows, err = stmt.Query(vals...)
		if err != nil {
			log.Fatal("Error while fetching rows from database:: ", err)
			return false, rows
		}
		defer stmt.Close()
	} else {
		rows, err = con.Query(query)
		if err != nil {
			log.Fatal("Error while fetching data from database:: ", err)
			return false, rows
		}
	}

	defer con.Close()
	return true, rows
}

func (operation *Database_Operations) update_data(query string, parameters []interface{}) bool {
	db1 := Database_Connection{}
	con, _ := db1.get_connection()
	vals := []interface{}{}
	for i := 0; i < len(parameters); i++ {
		vals = append(vals, parameters[i])
	}
	stmt, preperr := con.Prepare(query)
	if preperr != nil {
		log.Fatal("Error while preparing query for update:: ", preperr)
		return false
	}
	_, err := stmt.Exec(vals...)
	if err != nil {
		log.Fatal("Error while updating data into database:: ", err)
		return false
	}
	defer stmt.Close()
	defer con.Close()
	return true
}

func (operation *Database_Operations) insert_data(query string, parameters []interface{}) (bool, sql.Result) {
	db1 := Database_Connection{}
	con, _ := db1.get_connection()
	vals := []interface{}{}
	for i := 0; i < len(parameters); i++ {
		vals = append(vals, parameters[i])
	}
	stmt, preperr := con.Prepare(query)
	if preperr != nil {
		log.Fatal("Error while preparing query for insert:: ", preperr)
	}
	result, err := stmt.Exec(vals...)
	if err != nil {
		log.Fatal("Error while inserting data into database:: ", err)
		return false, result
	}
	defer stmt.Close()
	defer con.Close()
	return true, result
}

func (operation *Database_Operations) delete_data(query string, parameters []interface{}) bool {
	db1 := Database_Connection{}
	con, _ := db1.get_connection()
	vals := []interface{}{}
	for i := 0; i < len(parameters); i++ {
		vals = append(vals, parameters[i])
	}
	stmt, preperr := con.Prepare(query)
	if preperr != nil {
		log.Fatal("Error while preparing delete query:: ", preperr)
		return false
	}
	_, err := stmt.Exec(vals...)
	if err != nil {
		log.Fatal("Error while deleting data from database:: ", err)
		return false
	}
	defer stmt.Close()
	defer con.Close()
	return true
}
