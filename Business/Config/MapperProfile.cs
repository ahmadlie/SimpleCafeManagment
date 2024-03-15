﻿using AutoMapper;
using DataAccess.Entities;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Config
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            CreateMap<UserDTO, User>();
            CreateMap<User, UserDTO>();
            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();
            CreateMap<ProductDTO, ProductListDTO>();
            CreateMap<ProductListDTO, ProductDTO>();
        }

    }
}
