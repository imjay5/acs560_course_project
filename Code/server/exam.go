/**************************************************************
 * exam.go
 *
 * Implements functions for Exam module
 *
 * 	                Version History
 *   Author          Type of change          Description
 *   Kanika			 Addition				 Created File

 **************************************************************/

package main

import (
	//"database/sql"
	"encoding/json"
	"fmt"
	_ "github.com/go-sql-driver/mysql"
)

type Exam struct {
	Exam_Title      string `json:"exam_title"`
	No_Of_Questions int    `json:"no_of_question"`
	Status          string `json:"status"`
	Created_By      string `json:"created_by"`
	Timer_Enabled   bool   `json:"timer_enabled"`
	Timer_Duration  int    `json:"timer_duration"`
}

func (exam Exam) create_exam(msg *json.Decoder) string {
	var examObj Exam
	op := Database_Operations{}
	msg.Decode(&examObj)
	query := "insert into exams values(NULL,?,?,?,NULL,?,?,?)"
	parameters := []interface{}{examObj.Exam_Title, examObj.No_Of_Questions, examObj.Status, examObj.Created_By, examObj.Timer_Enabled, examObj.Timer_Duration}
	flag, result := op.insert_data(query, parameters)
	var id int64
	if flag == true {
		id, _ = result.LastInsertId()
	}
	response := fmt.Sprintf("%s%d%s", `{"msg": "success", "exam_id": `, id, `}`)
	return response
}
