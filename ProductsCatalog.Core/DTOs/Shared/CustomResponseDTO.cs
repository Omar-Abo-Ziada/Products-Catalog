﻿namespace ProductsCatalog.Domain.DTOs.Shared
{
    public class CustomResponseDTO<T>
    {
        public T? Data { get; set; }
        public string? Message { get; set; }
        public bool Succeeded { get; set; }
        public List<string>? Errors { get; set; }
        public PaginationInfoDTO? PaginationInfo { get; set; }
    }
}