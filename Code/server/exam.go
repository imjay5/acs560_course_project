/**************************************************************
 * exam.go
 *
 * Implements functions for Exam module
 *
 * 	                Version History
 *   Author          Type of change          Description
 *   Kanika			 Addition				 Created File
 *   Kanika			 Addition				 Added methods get_exam and update_exam
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
	Exam_Id         int    `json:"exam_id"`
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

func (exam Exam) get_exam(msg *json.Decoder) string {
	var examObj Exam
	op := Database_Operations{}
	msg.Decode(&examObj)
	query := "select exam_title, no_of_questions, timer_enabled, timer_duration from exams where exam_id = ?"
	parameters := []interface{}{examObj.Exam_Id}
	_, rows := op.get_data(query, parameters)
	examData := new(Exam)
	for rows.Next() {
		_ = rows.Scan(&examData.Exam_Title, &examData.No_Of_Questions, &examData.Timer_Enabled, &examData.Timer_Duration)
	}
	var respObj = Exam{
		Exam_Id:         examObj.Exam_Id,
		Exam_Title:      examData.Exam_Title,
		No_Of_Questions: examData.No_Of_Questions,
		Timer_Enabled:   examData.Timer_Enabled,
		Timer_Duration:  examData.Timer_Duration,
	}
	response, _ := json.Marshal(respObj)
	return string(response)
}

func (exam Exam) update_exam(msg *json.Decoder) string {
	var examObj Exam
	op := Database_Operations{}
	msg.Decode(&examObj)
	query := "update exams set exam_title = ?, no_of_questions = ?, timer_enabled = ?, timer_duration = ? where exam_id = ?"
	parameters := []interface{}{examObj.Exam_Title, examObj.No_Of_Questions, examObj.Timer_Enabled, examObj.Timer_Duration, examObj.Exam_Id}
	flag := op.update_data(query, parameters)
	var response = ""
	if flag == true {
		response = fmt.Sprintf("%s%d%s", `{"msg": "success", "exam_id": `, examObj.Exam_Id, `}`)
	} else {
		response = fmt.Sprintf("%s%d%s", `{"msg": "failure", "exam_id": `, examObj.Exam_Id, `}`)
	}
	return response
}
