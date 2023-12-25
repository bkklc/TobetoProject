﻿using Business.Dtos.Requests.ClassroomInstructorRequests;
using Business.Dtos.Responses.ClassroomInstructorResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface ICourseInstructorService
{
    Task<CreatedCourseInstructorResponse> AddAsync(CreateCourseInstructorRequest createCourseInstructorRequest);
    Task<UpdatedCourseInstructorResponse> UpdateAsync(UpdateCourseInstructorRequest updateCourseInstructorRequest);
    Task<CourseInstructor> DeleteAsync(int id);
    Task<IPaginate<GetListCourseInstructorResponse>> GetAllAsync(PageRequest pageRequest);
}
