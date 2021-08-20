﻿using AutoMapper;
using CourseMarket.Services.Order.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseMarket.Services.Order.Application.Mapping
{
    class CustomMapping : Profile
    {
        public CustomMapping()
        {
            CreateMap<Domain.OrderAggregate.Order, OrderDto>().ReverseMap();
            CreateMap<Domain.OrderAggregate.OrderItem, OrderItemDto>().ReverseMap();
            CreateMap<Domain.OrderAggregate.Address, AddressDto>().ReverseMap();
        }
    }
}