async function createConfig(config) {
    try {
        const response = await fetch('http://192.168.38.51:5000/api/GreenHouseConfig/CreateConfig', {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(config)
        });
        
        const data = await response.json();
        
        if (response.ok) {
            alert("Configuração criada com sucesso!"); // Alerta de sucesso
        } else {
            alert(`Erro ao criar a configuração: ${data.message || "Erro desconhecido"}`);
            // Alerta de erro caso a resposta não seja bem-sucedida
        }

        console.log(data); // Exibe o resultado no console
    } catch (error) {
        alert("Erro na conexão com o servidor"); // Alerta caso ocorra um erro de conexão
        console.error(error);
    }
}

async function deleteAllConfigs() {
    const confirmDelete = confirm("Tem certeza de que deseja deletar todas as configurações?");
    if (!confirmDelete) return; // Cancela se o usuário não confirmar

    try {
        const response = await fetch('http://192.168.38.51:5000/api/GreenHouseConfig/DeleteAll', {
            method: 'DELETE'
        });
        
        if (response.ok) {
            alert("Todos os registros foram deletados com sucesso!");
        } else {
            alert("Erro ao deletar registros.");
        }
    } catch (error) {
        alert("Erro ao conectar com o servidor.");
        console.error(error);
    }
}