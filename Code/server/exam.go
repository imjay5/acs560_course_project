/**************************************************************
 * exam.go
 *
 * Implements functions for Exam module
 *
 * 	                Version History
 *   Author          Type of change          Description
 *   Kanika			 Addition				 Created File
 *   Kanika			 Addition				 Added methods create_exam(), get_exam() and update_exam()
 *   Kanika			 Addition				 Added update_exam_status() method
 *   Kanika			 Addition				 Added methods get_all_exams(), MarshalExams(), get_report
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
	GradeA          int    `json:gradeA`
	GradeB          int    `json:gradeB`
	GradeC          int    `json:gradeC`
}

type Exams []Exam

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
	query := "update exams set exam_title = ?, no_of_questions = ?, timer_enabled = ?, timer_duration = ?, status =? where exam_id = ?"
	parameters := []interface{}{examObj.Exam_Title, examObj.No_Of_Questions, examObj.Timer_Enabled, examObj.Timer_Duration, examObj.Status, examObj.Exam_Id}
	flag := op.update_data(query, parameters)
	var response = ""
	if flag == true {
		response = fmt.Sprintf("%s%d%s", `{"msg": "success", "exam_id": `, examObj.Exam_Id, `}`)
	} else {
		response = fmt.Sprintf("%s%d%s", `{"msg": "failure", "exam_id": `, examObj.Exam_Id, `}`)
	}
	return response
}

func (exam Exam) update_exam_status(msg *json.Decoder) string {
	var examObj Exam
	op := Database_Operations{}
	msg.Decode(&examObj)
	query := "update exams set status = ? where exam_id = ?"
	parameters := []interface{}{examObj.Status, examObj.Exam_Id}
	flag := op.update_data(query, parameters)
	var response = ""
	if flag == true {
		response = fmt.Sprintf("%s%d%s", `{"msg": "success", "exam_id": `, examObj.Exam_Id, `}`)
	} else {
		response = fmt.Sprintf("%s%d%s", `{"msg": "failure", "exam_id": `, examObj.Exam_Id, `}`)
	}
	return response
}

func (exam Exam) get_all_exams(msg *json.Decoder) string {
	var examObj Exam
	op := Database_Operations{}
	msg.Decode(&examObj)
	query := "select exam_id, exam_title, no_of_questions, status from exams where created_by = ?"
	parameters := []interface{}{examObj.Created_By}
	_, rows := op.get_data(query, parameters)
	examData := new(Exam)
	var objExams Exams
	for rows.Next() {
		_ = rows.Scan(&examData.Exam_Id, &examData.Exam_Title, &examData.No_Of_Questions, &examData.Status)
		objExams = append(objExams, Exam{
			Exam_Id:         examData.Exam_Id,
			Exam_Title:      examData.Exam_Title,
			No_Of_Questions: examData.No_Of_Questions,
			Status:          examData.Status,
		})
	}
	response := MarshalExams(objExams)
	return response
}

func MarshalExams(res Exams) string {
	response, _ := json.Marshal(res)
	return string(response)
}

func (exam Exam) get_report(msg *json.Decoder) string {
	var examObj Exam
	op := Database_Operations{}
	msg.Decode(&examObj)
	query := "SELECT A.exam_id, A.exam_title, A.no_of_questions, MAX(CASE WHEN A.gradeA_count !=0 THEN A.gradeA_count ELSE 0 END ) AS GradeA, MAX(CASE WHEN A.gradeB_count !=0 THEN A.gradeB_count ELSE 0  END ) AS GradeB, MAX( CASE WHEN A.gradeC_count !=0 THEN A.gradeC_count ELSE 0 END ) AS GradeC FROM ( SELECT ug.exam_id, ex.exam_title, ex.no_of_questions, IF( ug.grade =  'A', COUNT( ug.grade ) , 0 ) AS gradeA_count, IF( ug.grade =  'B', COUNT( ug.grade ) , 0 ) AS gradeB_count, IF( ug.grade =  'C', COUNT( ug.grade ) , 0 ) AS gradeC_count FROM exams ex, user_grades ug WHERE ex.exam_id = ug.exam_id GROUP BY ex.exam_id, ug.grade) A GROUP BY A.exam_id"
	parameters := []interface{}{}
	_, rows := op.get_data(query, parameters)
	examData := new(Exam)
	var objExams Exams
	for rows.Next() {
		_ = rows.Scan(&examData.Exam_Id, &examData.Exam_Title, &examData.No_Of_Questions, &examData.GradeA, &examData.GradeB, &examData.GradeC)
		objExams = append(objExams, Exam{
			Exam_Id:         examData.Exam_Id,
			Exam_Title:      examData.Exam_Title,
			No_Of_Questions: examData.No_Of_Questions,
			GradeA:          examData.GradeA,
			GradeB:          examData.GradeB,
			GradeC:          examData.GradeC,
		})
	}
	response := MarshalExams(objExams)
	return response
}
