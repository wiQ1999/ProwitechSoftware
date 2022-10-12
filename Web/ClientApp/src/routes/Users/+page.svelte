<script>
	export let users = [
		{ 
			login: "admin", 	
			password: "admin", 
			fullName: "Hubert Nowak", 
			id: 1 
		},
		{ 
			login: "test", 
			password: "test", 
			fullName: "Testowy teściu", 
			id: 2 
		},
		{
			login: "wiktor",
			password: "szczeszek",
			fullName: "Wiktor Szczeszek",
			id: 3,
		},
		{
			login: "hanna",
			password: "filipowska",
			fullName: "Hanna Filipowska",
			id: 4,
		},
		{
			login: "jezus",
			password: "chrystus",
			fullName: "Jezus Chrystus",
			id: 5,
		},
		{
			login: "michael",
			password: "yackson",
			fullName: "Michael Yackson",
			id: 6,
		},
		{
			login: "robert",
			password: "lewandoski",
			fullName: "Robert Lewandoski",
			id: 7,
		},
		{
			login: "test2",
			password: "test2",
			fullName: "Testowa teściowa",
			id: 8,
		},
		{ login: "test3", password: "test3", fullName: "Testowy zięć", id: 9 },
	];

	const deleteUser = (/** @type {number} */ id) => {
		users = users.filter((user) => user.id != id);
	};
</script>

<div class="text-column">
	<a href="/rejestracja"> Rejestracja!</a>
	<p>Tutaj będzie widok z zarządzaniem użytkownikami:</p>
	<table>
		<tr class="bold">
			<td>ID</td>
			<td>login</td>
			<td>hasło</td>
			<td>Imię i nazwisko</td>
			<td />
			<td />
		</tr>
		{#each users as user (user.id)}
			<tr>
				<td> {user.id}</td>
				<td> {user.login}</td>
				<td> {user.password}</td>
				<td> {user.fullName}</td>
				<td class="bold"
					><button on:click={() => deleteUser(user.id)}>Usuń</button
					></td
				>
				<td class="bold"
					><button on:click={() => deleteUser(user.id)}
						>Modyfikuj</button
					></td
				>
			</tr>
		{/each}
	</table>
</div>

<style>
	.text-column {
		width: 100%;
		align-items: center;
		text-align: center;
	}

	div {
		background-color: white;
	}

	.bold {
		font-weight: bold;
	}

	table {
		width: 95%;
		border-style: groove;
		border-color: red;
		border-width: 1px;
	}

	td {
		border-width: 1px;
		border-color: black;
		border-style: dashed;
		padding: 5px;
	}
</style>
