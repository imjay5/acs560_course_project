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
	"net/http"
)

func main() {
	fmt.Println("Launching server...")
	http.HandleFunc("/", handler)
	http.ListenAndServe(":8081", nil)
}

func handler(w http.ResponseWriter, req *http.Request) {
	controller := Controller{}
	response := controller.process_data(json.NewDecoder(req.Body), req.FormValue("key"))
	fmt.Fprintf(w, response)
}
