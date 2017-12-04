/**************************************************************
 * register.go
 *
 * Implements functions for User login module
 *
 * 	                Version History
 * ------------------------------------------------------------
 *   Author          Type of change          Description
 *   Jaya			 Addition				 Created File
 *   Jaya			 Addition				 Added methods login()
 *   Jaya			 Addition				 Added methods register()
 **************************************************************/

package main

import (
	"encoding/json"
	"fmt"
	"log"
)

type UserDetails struct {
	Name  string `json:"name"`
	Email string `json:"email"`
	Pwd   string `json:"password"`
}

func (user UserDetails) register(msg *json.Decoder) string {
	var userDetails UserDetails
	var op Database_Operations
	var user_id int
	var response string
	var flag bool

	json := msg.Decode(&userDetails)
	fmt.Println("Success", json)
	fmt.Println(userDetails.Email)

	query := "select user_id from user_details where email=?"
	parameters := []interface{}{userDetails.Email}
	flag, rows := op.get_data(query, parameters)
	fmt.Println(flag, user_id, rows)

	if rows.Next() {
		response = `{"msg": "failure"}`
	} else {
		query := "insert into user_details values(NULL,?,?,?,0,NULL,FALSE)"
		parameters := []interface{}{userDetails.Name, userDetails.Email, userDetails.Pwd}
		flag, result := op.insert_data(query, parameters)

		log.Println("flag", flag)
		log.Println(result)
		// fmt.Println(userDetails.Email)
		response = `{"msg": "success"}`

	}

	//End
	return response
}

func (login UserDetails) login(msg *json.Decoder) string {
	op := Database_Operations{}
	var userDetails UserDetails
	var user_id int
	var name string
	var admin_key bool
	var flag bool
	var password string

	json := msg.Decode(&userDetails)
	fmt.Println("Success", json)

	query := "select user_id,name,password,admin_key from user_details where email=?"
	parameters := []interface{}{userDetails.Email}
	flag, rows := op.get_data(query, parameters)
	for rows.Next() {

		err := rows.Scan(&user_id, &name, &password, &admin_key)
		if err != nil {
			log.Fatal(err)
		}
		log.Println("select result ", user_id, name, admin_key, flag)

	}

	response := fmt.Sprintf("%s%d%s%s%s%s%s%t%s", `{"msg": "success", "user_id": `, user_id, `,"name" : "`, name, `","password" : "`, password, `","admin_key" : `, admin_key, `}`)
	return response
}
