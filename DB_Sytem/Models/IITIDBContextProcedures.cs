﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using DB_Sytem.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace DB_Sytem.Models
{
    public partial interface IITIDBContextProcedures
    {
        Task<int> Delete_AllExamQuestionsAsync(int? ExamId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> Delete_BranchDeptAsync(int? branch_ID, int? dept_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> Delete_BrancheAsync(int? branch_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> Delete_DepartmentAsync(int? dept_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<delete_examResult>> delete_examAsync(int? id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> Delete_ExamQuestionAsync(int? questionId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<Delete_QuestionResult>> Delete_QuestionAsync(int? questionId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<delete_stResult>> delete_stAsync(int? id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<delete_st_examResult>> delete_st_examAsync(int? stId, int? examId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> Delete_StudentAnswersAsync(int? ExamID, int? StudentID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> Delete_StudentOneAnswerAsync(int? ExamID, int? StudentID, int? QuestionID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<deleteCourseResult>> deleteCourseAsync(int? ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<DeleteETopicResult>> DeleteETopicAsync(string Topic, int? CourseID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteStudentCourseAsync(int? std_id, int? course_id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<Dept_ins_DeleteResult>> Dept_ins_DeleteAsync(int? ins_id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<Dept_ins_InsertResult>> Dept_ins_InsertAsync(int? dept_id, int? ins_id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<Dept_ins_SelectResult>> Dept_ins_SelectAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<Dept_ins_UpdateResult>> Dept_ins_UpdateAsync(int? dept_id, int? ins_id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<exam_correctionResult>> exam_correctionAsync(int? examId, int? stId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<Generate_ExamResult>> Generate_ExamAsync(TimeSpan? time, DateTime? date, int? duration, int? crsID, OutputParameter<int?> exam_id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetCoursesAndStudentsByInstructorResult>> GetCoursesAndStudentsByInstructorAsync(int? InstructorID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetCourseTopicsResult>> GetCourseTopicsAsync(int? CourseID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetExamQuestionsAndChoicesResult>> GetExamQuestionsAndChoicesAsync(int? ExamID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetExamQuestionsWithStudentAnswersResult>> GetExamQuestionsWithStudentAnswersAsync(int? ExamID, int? StudentID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetStudentGradesResult>> GetStudentGradesAsync(int? StudentID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetStudentsByDepartmentResult>> GetStudentsByDepartmentAsync(int? DeptID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<INS_deleteResult>> INS_deleteAsync(int? INS_id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<Ins_Dept_Crs_DeleteResult>> Ins_Dept_Crs_DeleteAsync(int? dept_id, int? ins_id, int? course_id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<Ins_Dept_Crs_InsertResult>> Ins_Dept_Crs_InsertAsync(int? dept_id, int? ins_id, int? course_id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<Ins_Dept_Crs_SelectResult>> Ins_Dept_Crs_SelectAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<Ins_Dept_Crs_UpdateResult>> Ins_Dept_Crs_UpdateAsync(int? olddept_id, int? oldins_id, int? oldCourseID, int? dept_id, int? ins_id, int? course_id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<INS_insertResult>> INS_insertAsync(string ins_fname, string ins_lname, string ins_salary, string ins_degree, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<INS_selectResult>> INS_selectAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<ins_Stud_CrsResult>> ins_Stud_CrsAsync(int? st_id, int? crs_id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<INS_updateResult>> INS_updateAsync(int? INS_id, string ins_fname, string ins_lname, string ins_salary, string ins_degree, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> Insert_BranchDeptAsync(int? branch_ID, int? dept_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> Insert_BrancheAsync(int? branch_ID, string name, string location, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> Insert_DepartmentAsync(string name, int? manager_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> insert_examAsync(TimeSpan? time, DateTime? date, int? duration, int? crsID, OutputParameter<int?> new_exam_id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<insert_ExamQuestionResult>> insert_ExamQuestionAsync(int? ExamID, int? QuestionID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<insert_QuestionResult>> insert_QuestionAsync(string Text, string Type, string CorrectAns, int? Grade, int? CourseID, string option1, string option2, string option3, string option4, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> insert_stAsync(string fname, string lname, int? age, string address, int? deptId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<insert_st_examResult>> insert_st_examAsync(int? stIdint, int? examId, int? totalDgree, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<insert_StudentAnswersResult>> insert_StudentAnswersAsync(int? ExamID, int? StudentID, int? QuestionID, string Answer, int? Grade, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> insertCourseAsync(string Name, int? duration, int? grade, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<select_AllQuestionsResult>> select_AllQuestionsAsync(int? courseID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<Select_BrancheResult>> Select_BrancheAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<Select_DepartmentResult>> Select_DepartmentAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<select_examResult>> select_examAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<select_ExamQuestionsResult>> select_ExamQuestionsAsync(int? examId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<select_stResult>> select_stAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<select_st_examResult>> select_st_examAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<select_StudentAnswersResult>> select_StudentAnswersAsync(int? ExamID, int? StudentID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<selectALLCoursesResult>> selectALLCoursesAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<selectAllStudentCoursesResult>> selectAllStudentCoursesAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SelectAllTopicsResult>> SelectAllTopicsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SelectAllTopicsToSpecificCOurseResult>> SelectAllTopicsToSpecificCOurseAsync(int? CourseID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<selectCourseResult>> selectCourseAsync(int? CourseID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<selectStudentCourseResult>> selectStudentCourseAsync(int? st_id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> Update_BranchDeptAsync(int? branch_ID, int? dept_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> Update_BrancheAsync(int? branch_ID, string name, string location, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> Update_DepartmentAsync(int? dept_ID, string name, int? manager_ID, DateTime? hire_date, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> update_examAsync(int? id, TimeSpan? time, DateTime? date, int? duration, int? crsID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<update_examQuestionResult>> update_examQuestionAsync(int? ExamID, int? oldQuestionId, int? newQuestionId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<update_questionResult>> update_questionAsync(int? questionId, string Text, string Type, string CorrectAns, int? Grade, int? CourseID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> update_stAsync(int? id, string fname, string lname, int? age, string address, int? deptId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> update_st_examAsync(int? stId, int? examId, int? totalDgree, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<update_StudentAnswerResult>> update_StudentAnswerAsync(int? ExamID, int? StudentID, int? QuestionID, string Answer, int? Grade, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<updateCourseResult>> updateCourseAsync(int? ID, string Name, int? Duration, int? Grade, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<UpdateStudentCourseResult>> UpdateStudentCourseAsync(int? st_id, int? crs_id, int? newCrs_id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<UpdateTopicResult>> UpdateTopicAsync(string Topic, int? CourseID, int? NewCourseID, string NewTopic, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
