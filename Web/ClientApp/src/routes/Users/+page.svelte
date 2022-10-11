<script>
	let users = [
		{ login: "admin", password: "admin", fullName: "Hubert Nowak", id: 1 },
		{ login: "test", password: "test", fullName: "Testowy teściu", id: 2 },
	];

	const deleteUser = (/** @type {number} */ id) => {
		users = users.filter((user) => user.id != id)
	}
</script>

<svelte:head>
	<title>Users</title>
	<meta name="description" content="User Management" />
</svelte:head>

<div class="user-management">
	<form action="/rejestracja">
		<input type="submit" value="Rejestracja" /> Kliknij tutaj!
	</form>
</div>
<div class="text-column">
	Tutaj będzie widok z zarządzaniem użytkownikami:
	<table>
		<tr class="bold">
			<td>ID</td>
			<td>login</td>
			<td>hasło</td>
			<td>Imię i nazwisko</td>
			<td></td>
		</tr>
		{#each users as user (user.id)}
			<tr>
				<td> {user.id}</td>
				<td> {user.login}</td>
				<td> {user.password}</td>
				<td> {user.fullName}</td>
				<td class="bold"><button on:click={() => deleteUser(user.id)}>Usuń</button></td>
			</tr>
		{/each}
	</table>
</div>

<style>
	.user-management {
		background-color: gray;
	}

	div {
		background-color: white;
	}

	.bold {
		font-weight: bold;
	}
</style>
