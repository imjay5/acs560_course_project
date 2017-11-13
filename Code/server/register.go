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
	var test UserDetails
	var op Database_Operations
	json := msg.Decode(&test)
	fmt.Println("Success", json)

	query := "insert into user_details values(NULL,?,?,?,0,NULL,FALSE)"
	parameters := []interface{}{test.Name, test.Email, test.Pwd}
	flag, result := op.insert_data(query, parameters)

	// if flag == true {
	// 	log.Println("last id ", result.LastInsertId())
	// }
	log.Println("flag", flag)
	log.Println(result)
	// fmt.Println(test.Email)
	response := `{"msg": "success"}`
	return response
}

func (login UserDetails) login(msg *json.Decoder) string {
	op := Database_Operations{}
	var test UserDetails
	var user_id int
	var admin_key bool

	json := msg.Decode(&test)
	fmt.Println("Success", json)

	query := "select user_id,admin_key from user_details where email=? and password=?"
	parameters := []string{test.Email, test.Pwd}
	rows := op.get_data(query, parameters)
	for rows.Next() {

		err := rows.Scan(&user_id, &admin_key)
		if err != nil {
			log.Fatal(err)
		}
		log.Println("select result ", user_id, admin_key)
	}

	response := fmt.Sprintf("%s%d%s%t%s", `{"msg": "success", "user_id": `, user_id, `,"admin_key" : `, admin_key, `}`)
	return response
}
