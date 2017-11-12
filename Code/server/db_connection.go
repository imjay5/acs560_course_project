/**************************************************************
 * db_connection.go
 *
 * Implements database connection to MySQL database
 *
 * 	                Version History
 *   Author          Type of change          Description
 *   Kanika			 Addition				 Created File

 **************************************************************/

package main

import (
	"database/sql"
	_ "github.com/go-sql-driver/mysql"
	"log"
)

const db_user string = "ep_admin"
const db_pwd string = "admin123"
const database string = "exam_portal"

type Database_Connection struct {
	db *sql.DB
}

func (db *Database_Connection) get_connection() (*sql.DB, error) {
	conn, err := sql.Open("mysql", db_user+":"+db_pwd+"@/"+database)
	if err != nil {
		log.Fatal("Error while connecting to database:: ", err)
		return nil, err
	}
	log.Println("Connected to MySQL Database...")
	return conn, nil
}
