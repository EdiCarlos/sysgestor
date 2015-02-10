﻿using SysGestor.DAL.ProdutoDal;
using SysGestor.DTO.ProdutoDto;
using SysGestor.RESOURCE.Resources;
using SysGestor.RESOURCE.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.BLL.ProdutoBll
{
    public class GradeBll
    {
        GradeDal _gradeDal;

        public GradeBll()
        {
            _gradeDal = new GradeDal();
        }

        public void Inserir(GradeDto gradeDto)
        {
            AssertionConcern.AssertArgumentNotEmpty(gradeDto.Descricao, Errors.EmptyDescription);
            AssertionConcern.AssertArgumentNotEquals(gradeDto.Descricao,
                                                 GetEqualsGrade(gradeDto.Descricao),
                                                 Errors.EqualsValue);

            _gradeDal.Inserir(gradeDto);   
        }

        public void Alterar(GradeDto gradeDto)
        {
            AssertionConcern.AssertArgumentNotEmpty(gradeDto.Descricao, Errors.EmptyDescription);
            AssertionConcern.AssertArgumentNotEquals(gradeDto.Descricao,
                                                 GetEqualsGrade(gradeDto.Descricao),
                                                 Errors.EqualsValue);

            _gradeDal.Alterar(gradeDto);
        }

        public void Remove(int idGrade)
        {
            AssertionConcern.AssertArgumentNotNull(idGrade, Errors.InvalidId);

            _gradeDal.Remove(idGrade);
        }

        public void RemoveMass(int[] idGrade)
        {
            AssertionConcern.AssertArgumentNotNull(idGrade, Errors.InvalidId);

            _gradeDal.RemoveMass(idGrade);
        }

        public GradeDto GetGrade(int idGrade)
        {
            AssertionConcern.AssertArgumentNotNull(idGrade, Errors.InvalidId);

            return _gradeDal.GetGrade(idGrade);
        }

        public string GetEqualsGrade(string descricao)
        {
           return _gradeDal.GetEqualsCategoria(descricao);
        }

        public List<GradeDto> FindAll(string searchValue, object filter)
        {
            var grades = new List<GradeDto>();

            grades = _gradeDal.FindAll().ToList();

            if (searchValue == "Descricao" && filter != "")
                return grades.Where(x => x.Descricao.Contains(Convert.ToString(filter))).ToList();

            if (searchValue == "Id" && filter != "")
                return grades.Where(x => x.Id == Convert.ToInt32(filter)).ToList();

            return grades;
        }
    }
}
