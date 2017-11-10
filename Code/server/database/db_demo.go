/**************************************************************
 * db_demo.go
 *
 * Implements demo of usage database operations
 *
 * 	                Version History
 *   Author          Type of change          Description
 *   Kanika			 Addition				 Created File

 **************************************************************/

package main

import (
	_ "github.com/go-sql-driver/mysql"
	"log"
)

var (
	username  string
	firstname string
	lastname  string
	flag      bool
)

func main() {
	op := Database_Operations{}
	//select example
	query := "select username, firstname, lastname, flag from temp where firstname=? and lastname=?"
	parameters := []string{"User1", "UL1"}
	//parameters := []string{}   if there are no parameters in the query
	rows := op.get_data(query, parameters)
	for rows.Next() {
		err := rows.Scan(&username, &firstname, &lastname, &flag)
		if err != nil {
			log.Fatal(err)
		}
		log.Println(username, firstname, lastname, flag)
	}

	//insert example
	query = "insert into temp values(?,?,?,?)"
	parameters = []string{"K456", "User3", "UL3", "0"}
	//flag := op.insert_data(query, parameters)
	log.Println("flag", flag)
}
