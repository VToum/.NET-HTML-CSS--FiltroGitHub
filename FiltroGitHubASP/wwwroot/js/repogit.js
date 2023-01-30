const repositorios = document.querySelector('.content-main');

function getApiGitHub() {
    fetch('https://api.github.com/users/VToum/repos')
        .then(async res => {
            if (!res.ok) {
                throw new Error(res.status);
            }

            let data = await res.json();
            console.log(data);
            data.map(item => {
                let project = document.createElement('div');

                project.innerHTML = `
                       <div class="project">
                          <div>
                           <h3 class="title">${ item.name}</h3>
                           <h6 class="title">${ item.description}</h5>
                           <span class="data-create">${ Intl.DateTimeFormat('pt-BR').format(new Date(item.created_at)) }</span>
                        </div>
                            <div>
                                <a href="${item.html_url}" target="_blank">${item.html_url}</a>
                                <span class="language"><span class="circle"></span>${item.language}</span>
                        </div>
                         </div>
                `

                repositorios.appendChild(project);
            })
        })

}

getApiGitHub();