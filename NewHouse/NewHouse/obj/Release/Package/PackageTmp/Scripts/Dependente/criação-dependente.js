$(function () {
    var qtdDependentes = 0;

    $("#btn-add-dependente").click(function (e) {
        e.preventDefault();

        var blocoDependente = '<div class="row">' +
            '    <div class="col-md-5">' +
            '        <input type="text" name="Dependentes[' + qtdDependentes + '].Nome" placeholder="Nome" class="form-control input-block-level text-nome" />' +
            '    </div>' +
            '    <div class="col-md-3">' +
            '        <input type="text" name="Dependentes[' + qtdDependentes + '].CPF" placeholder="CPF" maxlength="11" class="form-control text-cpf" />' +
            '    </div>' +
            '    <div class="col-md-2">' +
            '        <input type="number" name="Dependentes[' + qtdDependentes + '].Idade" min="1" placeholder="Idade" class="form-control number-idade" />' +
            '    </div>' +
            '    <div class="col-md-1">' +
            '       <input type="checkbox" value="true" name="Dependentes[' + qtdDependentes + '].Debilitado" class="form-control checkbox-debilitado" /> ' +
            '    </div>' +
            '    <div class="col-md-1">' +
            '        <button class="btn btn-danger btn-remover-dependente">' +
            '            <span class="glyphicon glyphicon-trash"></span>' +
            '        </button>' +
            '    </div>' +
            '</div>';

        $("#div-dependentes").append(blocoDependente);

        qtdDependentes++;
    });

    $("#div-dependentes").on("click", ".btn-remover-dependente", function (e) {
        e.preventDefault();

        $(this).parent().parent().remove();

        qtdDependentes--;

        $("#div-dependentes .row").each(function (indice, elemento) {
            $(elemento).find(".txt-nome").attr("name", "Dependentes[" + indice + "].Nome");
            $(elemento).find(".txt-cpf").attr("name", "Dependentes[" + indice + "].CPF");
            $(elemento).find(".number-idade").attr("name", "Dependentes[" + indice + "].Idade");
            $(elemento).find(".checkbox-debilitado").attr("name", "Dependentes[" + indice + "].Debilitado");
        });
    });
});