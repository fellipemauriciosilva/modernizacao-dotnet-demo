document.addEventListener("DOMContentLoaded", function () {
    const form = document.getElementById("clienteForm");
    form.addEventListener("submit", function (e) {
        e.preventDefault();
        const nome = document.getElementById("nome").value;

        fetch("/api/clientes", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify({ nome })
        })
        .then(res => {
            if (res.ok) alert("Cliente salvo com sucesso!");
            else alert("Erro ao salvar cliente.");
        });
    });
});
