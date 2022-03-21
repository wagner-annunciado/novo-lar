$(function () {
    var qtdNaoDependentes = 0;

    $("#btn-add-nao-dependente").click(function (e) {
        e.preventDefault();

        var blocoNaoDependente = '<div class="row">' +
            '    <div class="col-md-5">' +
            '        <input type="text" name="NaoDependentes[' + qtdNaoDependentes + '].Nome"  placeholder="Nome" class="form-control text-nomen" />' +
            '    </div>' +
            '    <div class="col-md-2">' +
            '        <input type="text" name="NaoDependentes[' + qtdNaoDependentes + '].CPF" placeholder="CPF" class="form-control text-cpfn" />' +
            '    </div>' +
            '    <div class="col-md-2">' +
            '        <input type="number" name="NaoDependentes[' + qtdNaoDependentes + '].Idade" min="1" placeholder="Idade" class="form-control number-idaden" />' +
            '    </div>' +
            '    <div class="col-md-2">' +
            '        <input type="number"  name="NaoDependentes[' + qtdNaoDependentes + '].Renda" placeholder="Renda R$" class="form-control number-rendan" />' +
            '    </div>' +
            '    <div class="col-md-1">' +
            '        <button class="btn btn-danger btn-remover-nao-dependente">' +
            '            <span class="glyphicon glyphicon-trash"></span>' +
            '        </button>' +
            '    </div>' +
            '</div>';

        $("#div-nao-dependentes").append(blocoNaoDependente);

        qtdNaoDependentes++;
    });

    $("#div-nao-dependentes").on("click", ".btn-remover-nao-dependente", function (e) {
        e.preventDefault();

        $(this).parent().parent().remove();

        qtdNaoDependentes--;

        $("#div-dependentes .row").each(function (indice, elemento) {
            $(elemento).find(".text-nomen").attr("name", "NaoDependentes[" + indice + "].Nome");
            $(elemento).find(".text-cpfn").attr("name", "NaoDependentes[" + indice + "].CPF");
            $(elemento).find(".number-idaden").attr("name", "NaoDependentes[" + indice + "].Idade");
            $(elemento).find(".number-rendan").attr("name", "NaoDependentes[" + indice + "].Renda");
        });
    });
});