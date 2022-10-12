<script>
	/**
	 * @type {any}
	 */
	let name;
	/**
	 * @type {{ value: any; }}
	 */
	let password;
	/**
	 * @type {{ value: any; }}
	 */
	let password2;
	/**
	 * @type {string}
	 */
	let firstName;
	/**
	 * @type {string}
	 */
	let lastName;
	/**
	 * @type {any}
	 */
	let phoneNumber;
	// @ts-ignore
	let fullName = firstName + " " + lastName;

</script>

<main>
	<div class="registerForm">
		<form>
			<label>
				Logowanie: <br>
				<input
					type="text"
					placeholder="Nazwa użytkownika"
					bind:value={name}
				/> <br>
					<input
						type="password"
						placeholder="Hasło"
					/> <br>
					<input
						type="password"
						placeholder="Powtórz hasło"
					/><br>
			</label>
			<label>
				Dane: <br>
				<input type="text" placeholder="Imię"/> <br>
				<input
					type="text"
					placeholder="Nazwisko"
				/> <br>
				<input
					type="text"
					placeholder="Telefon"
				/>
			</label>
		</form>
	</div>
</main>

<style>
	.registerForm {
		width: 100%;
		text-align: center;
	}
</style>
