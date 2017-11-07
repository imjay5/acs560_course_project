/**************************************************************
 * server.go
 *
 * Implements functions for receiving data from C# client
 *
 * 	                Version History
 *   Author          Type of change          Description
 *   Kanika			 Addition				 Created File

 **************************************************************/

package main

import (
	"encoding/json"
	"fmt"
	"log"
	"net/http"
)

func main() {
	fmt.Println("Launching server...")
	http.HandleFunc("/", handler)
	http.ListenAndServe(":8081", nil)
}

type test_struct struct {
	User string `json:"user"`
	Pwd  string `json:"password"`
}

func handler(w http.ResponseWriter, req *http.Request) {
	var test test_struct
	err := json.NewDecoder(req.Body).Decode(&test)
	if err != nil {
		http.Error(w, err.Error(), 400)
		return
	}
	fmt.Println("******* ", test.User)
	str := `{"page": 1, "fruits": ["apple", "peach"]}`
	fmt.Fprintf(w, str)
}
