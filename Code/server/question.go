/**************************************************************
 * question.go
 *
 * Implements functions for adding questions to exams
 *
 * 	                Version History
 *   Author          Type of change          Description
 *   Kanika			 Addition				 Created File

 **************************************************************/

package main

import (
	"encoding/json"
	"fmt"
	_ "github.com/go-sql-driver/mysql"
)

type Question struct {
	ExamId           int    `json:"exam_id"`
	Question         string `json:"question"`
	OptionA          string `json:"option_a"`
	OptionB          string `json:"option_b"`
	OptionC          string `json:"option_c"`
	OptionD          string `json:"option_d"`
	Answer           string `json:"answer"`
	Difficulty_Level string `json:"difficulty_level"`
	Question_Id      int    `json:"question_id"`
}

func (question Question) add_question(msg *json.Decoder) string {
	var quesObj Question
	op := Database_Operations{}
	msg.Decode(&quesObj)
	query := "insert into questions values(NULL,?,?,?,?,?,?,?,?)"
	parameters := []interface{}{quesObj.ExamId, quesObj.Question, quesObj.OptionA, quesObj.OptionB, quesObj.OptionC, quesObj.OptionD,
		quesObj.Answer, quesObj.Difficulty_Level}
	fmt.Println("exam id ", quesObj.ExamId)
	flag, result := op.insert_data(query, parameters)
	var id int64
	if flag == true {
		id, _ = result.LastInsertId()
	}
	response := fmt.Sprintf("%s%d%s", `{"msg": "success", "question_id": `, id, `}`)
	return response
}

func (question Question) get_next_question(msg *json.Decoder) string {
	var quesObj Question
	op := Database_Operations{}
	msg.Decode(&quesObj)
	var query string
	if quesObj.Question_Id != 0 {
		query = "select question_id, question, option_a, option_b, option_c, option_d, answer, difficulty_level from questions where exam_id = ? and question_id > ? LIMIT 1"
	} else {
		query = "select question_id, question, option_a, option_b, option_c, option_d, answer, difficulty_level from questions where exam_id = ? LIMIT 1"
	}
	parameters := []interface{}{quesObj.ExamId}
	_, rows := op.get_data(query, parameters)
	questionData := new(Question)
	for rows.Next() {
		_ = rows.Scan(&questionData.Question_Id, &questionData.Question, &questionData.OptionA, &questionData.OptionB, &questionData.OptionC, &questionData.OptionD, &questionData.Answer, &questionData.Difficulty_Level)
	}
	var respObj = Question{
		ExamId:           quesObj.ExamId,
		Question_Id:      questionData.Question_Id,
		Question:         questionData.Question,
		OptionA:          questionData.OptionA,
		OptionB:          questionData.OptionB,
		OptionC:          questionData.OptionC,
		OptionD:          questionData.OptionD,
		Answer:           questionData.Answer,
		Difficulty_Level: questionData.Difficulty_Level,
	}
	response, _ := json.Marshal(respObj)
	return string(response)
}

func (question Question) delete_question(msg *json.Decoder) string {
	var quesObj Question
	op := Database_Operations{}
	msg.Decode(&quesObj)
	query := "delete from questions where exam_id=? and question_id=?"
	parameters := []interface{}{quesObj.ExamId, quesObj.Question_Id}
	flag := op.delete_data(query, parameters)
	var response string
	if flag == true {
		response = `{"msg": "success" }`
	} else {
		response = `{"msg": "fail" }`
	}
	return response
}
