using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using CharSheet.Domain;
using CharSheet.Domain.Interfaces;

namespace CharSheet.Data.Repositories
{
    public class FormTemplateRepository : GenericRepository<FormTemplate>, IFormTemplateRepository
    {
        public FormTemplateRepository(CharSheetContext context)
            : base(context)
        { }

        public async override Task<FormTemplate> Find(object id)
        {
            return (await Get(FormTemplate => FormTemplate.FormTemplateId == (Guid) id, null, "FormPosition")).FirstOrDefault();
        }

        public async Task<IEnumerable<FormLabel>> GetFormLabels(object id)
        {
            return await base._context.FormLabels.Where(formLabel => formLabel.FormTemplateId == (Guid) id).OrderBy(formLabel => formLabel.Index).ToListAsync();
        }
    }
}